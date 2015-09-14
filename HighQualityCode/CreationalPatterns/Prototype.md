# **Creational Design Patterns** #


##**Prototype**##
**Мотивация**

Определя прототипна инстанция на някакъв вид обект и създава нови обекти чрез копиране на прототипа.


----------
**Цел**

Prototype е създаващ шаблон за дизайн. Създава обекти с помощта на обект-прототип. Новите обекти се създават чрез клониране на прототипа, вместо с използване на конструктор.


----------
**Приложение**

Копиране на уеб ресурси вместо да се свалят наново. Скриване на конструктора и позволяване на клониране.


----------
**Употреба**

Удобството да се клонират обекти вместо да се създават с new word.


----------
**Имплементация**

```cs
static class Program
{
    static void Main()
    {
        ConcretePrototype prototype = new ConcretePrototype("1");
        ConcretePrototype clone = (ConcretePrototype)prototype.Clone();
        Console.WriteLine("Cloned: {0}", clone.Id);
    }
}

abstract class Prototype
{
    private readonly string _id;

    protected Prototype(string id)
    {
        _id = id;
    }

    public string Id
    {
        get { return _id; }
    }

    public abstract Prototype Clone();
}

class ConcretePrototype : Prototype
{
    public ConcretePrototype(string id)
        : base(id)
    {
    }
    public override Prototype Clone()
    {
        return (Prototype)MemberwiseClone();
    }
}
```


----------
**Участници**

Prototype

ConcretePrototype


----------
**Структура**

![enter image description here](https://github.com/tokera/TelerikAcademyHomeworks/blob/master/HighQualityCode/CreationalPatterns/images/Prototype.jpg)

   
