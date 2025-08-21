using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task_1
{
    public class Citrus:Fruit
    {
        double VitaminC;


        public Citrus(string name, double vitaminC): base(name, "Citrus")
        {
            this.VitaminC = vitaminC;
        }


        public override void Input()
        {
            var input = Console.ReadLine();
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, vitamin: {VitaminC}");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Color: {Color}";
        }

        public void Print(string filePath, bool append)
        {
            try
            {
                using (var writer = new StreamWriter(filePath))
                {
                    writer.WriteLine($"{Name},{Color},{VitaminC}");
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
                    VitaminC = double.Parse(parts[2]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while reading the file: " + ex.Message);
            }
        }
    }
}
