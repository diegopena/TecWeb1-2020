using System;

namespace Clase_2
{
    public class Shape
    {
        public string name { get; set; }

        public string color { get; set; }

        public virtual void Show()
        {
            //Console.WriteLine(string.Format("my name is {0} shape", name));
            Console.WriteLine($"my name ins {name} shape");
        }
    }

    public class Square : Shape
    {
        public override void Show()
        {
            Console.WriteLine($"im a square {name}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Shape myShape = new Shape("basic");
            Shape myShape = new Square() {name = "basic", color = "blue"};
            myShape.Show();

            Console.WriteLine("Hello World!");
        }
    }
}
