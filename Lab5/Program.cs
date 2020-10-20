using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task_5
            Engine engine = new Engine("diesel", 167, 7.1, 2.4);
            Car car = new Car(4, 1222, 3.5, 210, 2004, "Volvo v60", engine);
            car.Info();

            if (car is Transport) Console.WriteLine("Объект car принадлежит классу Transport.\n");
            else Console.WriteLine("Объект car не принадлежит классу Transport.\n");

            Human human = new Human("Grisha", "Bulgak", 2002);
            human.Info();
            Engine engine1 = new Engine("diesel", 167, 7.1, 2.4);
            Transformer transformer = new Transformer(4, 1500, 3.6, 250, 2016, "Range Rover", engine1);
            transformer.Info();

            if (transformer is Transport) Console.WriteLine("Объект transformer принадлежит классу Transport.\n");
            else Console.WriteLine("Объект transformer не принадлежит классу Transport.\n");

            if (human is Driving) Console.WriteLine("Объект human принадлежит классу Driving.\n");
            else Console.WriteLine("Объект human не принадлежит классу Driving.\n");

            Transport car_copy = car as Transport;
            Console.WriteLine(car_copy.ToString());
            #endregion

            #region task_6
            Car car1 = new Car(4, 1222, 3.5, 210, 2004, "Volvo v60", new Engine("petrol", 320, 8, 3.2));
            Transformer transformer1 = new Transformer(4, 1222, 3.5, 210, 2004, "Volvo v60", new Engine("petrol", 320, 8, 3.2));
            Printer printer = new Printer();
            Transport[] transports = new Transport[] { car1, transformer1 };
            Console.WriteLine();
            foreach (var item in transports)
            {
                printer.IAmPrinting(item);
                Console.WriteLine();
            }
            #endregion
        }
    }
}
