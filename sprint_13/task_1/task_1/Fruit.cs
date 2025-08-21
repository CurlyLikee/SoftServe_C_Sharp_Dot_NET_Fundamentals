using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class Fruit
    {
        public string Name { get; set; } 
        public string Color { get; set; }


        public Fruit(string name, string color)
        {
            this.Name = name;
            this.Color = color;
        }

        public virtual void Input()
        {
            var input = Console.ReadLine();
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}, Color: {Color}");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Color: {Color}";
        }

        public void Print(string filePath, bool append)
        {
            try
            {
                using (var writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"Name: {Name}, Color: {Color}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while writing to the file: " + ex.Message);
            }
        }

        public void Input(string filePath)
        {
            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    var line = reader.ReadLine();
                    var parts = line.Split(',');
                    Name = parts[0];
                    Color = parts[1];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while reading the file: " + ex.Message);
            }
        }
    }
}
