using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_HW_6
{
    using System;

    class Car
    {
        private string name;
        private int maxSpeed;

        // Конструктор з параметрами
        public Car(string name, int maxSpeed)
        {
            this.name = name;
            this.maxSpeed = maxSpeed;
        }

        // Властивість для доступу до поля "Назва" (Name)
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Властивість для доступу до поля "Максимальна швидкість" (MaxSpeed)
        public int MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value; }
        }

        public static string Max_Speed(Car car1, Car car2)
        {
            if (car1.MaxSpeed > car2.MaxSpeed)
            {
                return $"{car1.Name} має бiльшу швидкiсть";
            }
            else if (car2.MaxSpeed > car1.MaxSpeed)
            {
                return $"{car2.Name} має бiльшу швидкiсть";
            }
            else
            {
                return "Швидкостi обох автомобiлiв рiвнi";
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Car car1 = new Car("Honda", 120);
            Car car2 = new Car("Opel", 255);
            string result = Car.Max_Speed(car1, car2);
            Console.WriteLine(result);
        }
    }

}
