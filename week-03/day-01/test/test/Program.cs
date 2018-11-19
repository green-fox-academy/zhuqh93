using System;

namespace test
{
    public interface IMoveable
    {
        void Move(int meter);
    }

    public class Car : IMoveable
    {
        public int distanceTaken;

        public Car()
        {
            distanceTaken = 0;
        }

        public void Move(int meter)
        {
            distanceTaken += meter;
        }
    }

    class Example
    {
        public static void Main(string[] args)
        {
            var car = new Car();
            car.Move(100);
            Console.WriteLine(car.distanceTaken);

            IMoveable something = new Car();
            something.Move(200);
            // #1
            //            Console.WriteLine(((Car)something).distanceTaken);

            // #2
            Car car2 = something as Car;
            // #2.1
            //            if (car2 != null)
            //            {
            //                Console.WriteLine(car2.distanceTaken);
            //            }
            // #2.2
            // Console.WriteLine(car2?.distanceTaken);

            // #3
//            if (something is Car car1)
//            {
//                Console.WriteLine(car1.distanceTaken);
//            }

            Console.ReadLine();
        }
    }
}
