using System;
namespace WorkshopPrograms
{
    public class TemperatureConversion
    {
        public void TempConversion(int temp)
        {
            Console.WriteLine("1.Convert Celsius to Fahrenheit\n2.Convert Fahrenheit to Celsius");
            try
            {
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        float fahr = (temp * (9 / 5f)) + 32;
                        Console.WriteLine("{0}C into Fahrenheit is {1}F", temp, fahr);
                        break;
                    case 2:
                        float cels = (temp - 32) * (5 / 9f);
                        Console.WriteLine("{0}F into Celsius is {1}C", temp, cels);
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
