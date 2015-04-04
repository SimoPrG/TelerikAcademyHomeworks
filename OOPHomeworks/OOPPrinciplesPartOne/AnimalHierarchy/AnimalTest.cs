namespace AnimalHierarchy
{
    using System;
    using System.Linq;

    class AnimalTest
    {
        static void Main()
        {
            var dogs = new Dogs[] {
                                      new Dogs("Rex", 7, Sex.Male),
                                      new Dogs("Sharo", 11, Sex.Male),
                                      new Dogs("Sara", 15, Sex.Famale)
                                  };

            var frogs = new Frogs[] {
                                        new Frogs("Crazy Frog", 3, Sex.Male),
                                        new Frogs("Pesho", 5, Sex.Male),
                                        new Frogs("Jabka", 2, Sex.Famale)
                                    };

            var cats = new Cats[] {
                                      new Tomcats("Tom", 5),
                                      new Kittens("Kitty", 4),
                                      new Cats("Kotan", 6, Sex.Male)
                                  };

            var averageAgeOfDogs = dogs.Average(d => d.Age);
            var averageAgeOfFrogs = frogs.Average(f => f.Age);
            var averageAgeOfCats = cats.Average(c => c.Age);


            Console.WriteLine("Avarage age of dogs: {0:F1}", averageAgeOfCats);
            Console.WriteLine("Avarage age of frogs: {0:F1}", averageAgeOfFrogs);
            Console.WriteLine("Avarage age of cats: {0:F1}", averageAgeOfCats);
        }
    }
}
