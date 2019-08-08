using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices_Classes_July_07_2019
{
    // Create a class called "Dog". It has these memnber variables:
    // 1-name
    // 2-breed
    // 3-a method named "bark()" that prints out"bark!"
    // 4-a method named "draw()" that prints out "The dog is drawn on the window".
    // Then create two dogs (objects) out of this class and give them name and breed. Also call bark() and draw() methods.
    class Dog
    {
        public string name;
        public string breed;

        public void bark()
        {
            Console.WriteLine("bark!");
        }
        public void draw()
        {
            Console.WriteLine($"The {name} is drawn on the window");
        }
        
    }
    class Program
    {

        static void Main(string[] args)
        {
            Dog Peach = new Dog();
            Peach.name = "Peach";
            Peach.breed = "Poodle";
            Peach.bark();
            Peach.draw();
            Dog Honey = new Dog();
            Honey.name = "Honey";
            Honey.breed = "Labrador";
            Honey.bark();
            Honey.draw();
        
        }
    }
}
