using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonNewCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("New car!");
            
            Car rabbit = new Car();
            Car white = new Car();
            rabbit.Travel(100);
            Console.WriteLine(rabbit.ToString());
            WashingCar.Washing(rabbit);
            Console.WriteLine(rabbit.ToString());
            rabbit.Travel(1000);
            
            Console.WriteLine(rabbit.ToString());
            WashingCar.Washing(rabbit);
            RepairCar.Repair(rabbit);
            Console.WriteLine("Rabbit должен работать");
            Console.WriteLine(rabbit);
            rabbit.Travel(900);
            Console.WriteLine(rabbit);
            RepairCar.Repair(rabbit);
            rabbit.Travel(200);
            Console.WriteLine(rabbit);



            Console.ReadKey();
            
        }
    }
}
