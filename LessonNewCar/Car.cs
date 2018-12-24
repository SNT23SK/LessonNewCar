using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonNewCar
{
    public class Car
    {
        #region Variables
        bool IsDirty;
        bool IsWork;
        int id;
        static int count=1;
        double lenght;
        #endregion
        public Car()
        {
            IsDirty = false;
            IsWork = true;
            lenght = 0;
            id = count++;
            
        }
        /// <summary>
        /// Свойство машины Как Выглядит
        /// Возврвщвет IsDirty</summary>
        public bool Look
        {
            get
            {
                return IsDirty;
            }
            set
            {
                 IsDirty = value;
            }
        }
        /// <summary>
        /// Свойство работоспособности машины
        /// Возвращает IsWorking</summary>
        public bool StateIsWorking
        {
            get
            {
                return IsWork;  
            }
             set
            {
                 IsWork = value;
            }
           
        }
        public double Mealage
        {
            get
            {
                return lenght;
            }
            private set
            {
               
            }
        }
        public void Travel(double path)
        {
            double pred;
            pred = path + Mealage;
            if (path<0)
            {
                throw new Exception("Значение не может быть меньше нуля");
            }
            else if ((path>=1000)||(pred>=1000))
            {
                lenght = 1000;
                StateIsWorking = false;
                Look = true;
            }
            else if ((path<=2000)||(pred>=2000))
            {
                lenght = 2000;
                StateIsWorking = false;
                Look = true;
            }
            else if ((path >= 5000) || (pred >= 5000))
            {
                lenght = 5000;
                StateIsWorking = false;
                Look = true;
            }
            else
            {
                lenght = lenght + path;
                Look = true;
            }
             
        }
        /// <summary>
        /// Перезагрузка метода ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string Look = this.IsDirty ? "грязная" : "чистая";
            string StateIsWorking = this.IsWork ? "рабочая" : "сломанная";
            return string.Format ("Машина N {0} пробег: {1}  Состояние: {2} , {3}",id,Mealage,Look,StateIsWorking );
        }





    }
}
