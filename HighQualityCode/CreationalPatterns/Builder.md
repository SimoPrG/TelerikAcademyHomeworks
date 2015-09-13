# **Creational Design Patterns** #


##**Builder**##


----------


###**Мотивация**

**Builder** позволява създаването на сложен обект стъпка по стъпка използвайки конкретна поредица от действия, така че един и същи процес да може да създава обекти с различно представяне. Конструкцията се контролира от директор.

###**Цел**

Целта е да се раздели създаването на сложен обект от неговото представяне (интерфейс), за да може с един и същ процес да се създават обекти с различно представяне.

###**Приложение**

XML документи

###**Имплементация**

```
using System;
using System.Collections;

 namespace Builder
 {

  public class MainApp
  {
    public static void Main()
    {
      // Create director and builders
      Director director = new Director();

      Builder b1 = new ConcreteBuilder1();
      Builder b2 = new ConcreteBuilder2();

      // Construct two products
      director.Construct(b1);
      Product p1 = b1.GetResult();
      p1.Show();

      director.Construct(b2);
      Product p2 = b2.GetResult();
      p2.Show();

      // Wait for user
      Console.Read();
    }
  }

  // "Director"

  class Director
  {
    // Builder uses a complex series of steps
    public void Construct(Builder builder)
    {
      builder.BuildPartA();
      builder.BuildPartB();
    }
  }

  // "Builder"

  abstract class Builder
  {
    public abstract void BuildPartA();
    public abstract void BuildPartB();
    public abstract Product GetResult();
  }

  // "ConcreteBuilder1"

  class ConcreteBuilder1 : Builder
  {
    private readonly Product product = new Product();

    public override void BuildPartA()
    {
      product.Add("PartA");
    }

    public override void BuildPartB()
    {
      product.Add("PartB");
    }

    public override Product GetResult()
    {
      return product;
    }
  }

  // "ConcreteBuilder2"

  class ConcreteBuilder2 : Builder
  {
    private readonly Product product = new Product();

    public override void BuildPartA()
    {
      product.Add("PartX");
    }

    public override void BuildPartB()
    {
      product.Add("PartY");
    }

    public override Product GetResult()
    {
      return product;
    }
  }

  // "Product"

  class Product
  {
    private readonly ArrayList parts = new ArrayList();

    public void Add(string part)
    {
      parts.Add(part);
    }

    public void Show()
    {
      Console.WriteLine("\nProduct Parts -------");
      foreach (string part in parts)
        Console.WriteLine(part);
    }
  }
 } 
```

###**Участници**

Product

Builder

ConcreteBuilder

Director

###**Структура**

![enter image description here](https://github.com/tokera/TelerikAcademyHomeworks/blob/master/HighQualityCode/CreationalPatterns/images/Builder.jpg)