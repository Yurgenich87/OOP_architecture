using System;

namespace ModelElements;

    public class Scene
    {
        public int Id { get; set; }
        public PoligonalModel Models { get; set; }
        public Flash Flashes { get; set; }

        public Scene(int id, PoligonalModel models, Flash flashes)
        {
            Id = id;
            Models = models;
            Flashes = flashes;
        }

        public Type Method1(Type argument)
        {
            // Реализация метода Method1
            Console.WriteLine($"Метод1 вызывается с аргументом:: {argument}");
            return typeof(Type); 
        }

        public Type Method2(Type argument1, Type argument2)
        {
            // Реализация метода Method2
            Console.WriteLine($"Метод2 вызывается с аргументом:: {argument1} and {argument2}");
            return typeof(Type); 
        }
    }

   
