using System;
namespace WorkshopPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Workshop Programs\n");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select from the following\n1.Temperatureconversion\n2.Exit");
                Console.Write("Enter your choice: ");
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            TemperatureConversion convert = new TemperatureConversion();
                            convert.TempConversion(100);
                            Console.WriteLine("--------------------------------------\n");
                            break;
                        case 2:
                            flag = false;
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}