using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonNewCar
{
    public static class RepairCar
    {
        public static void Repair(Car car)
        {
            car.StateIsWorking = true;
        }
    }
}
