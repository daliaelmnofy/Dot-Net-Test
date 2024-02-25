using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Program
    {
        
    static void Main(string[] args)
        {
            //male
            WeightCalc weightCalcMale = new WeightCalc
            {
                hight = 170,
                gender = 'M'
            };
            double wightM = weightCalcMale.GetWight();
            Console.WriteLine($"Ideal wight for Male ={wightM}");
            if (wightM == 65)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Test for Male Succeeded");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Test for Male failed");
            }

            //female
            //WeightCalc weightCalcFemale = new WeightCalc
            //{
            //    hight = 176,
            //    gender ='F'
            //};
            //double wightW = weightCalcFemale.GetWight();
            //Console.WriteLine($"Ideal wight for Female ={wightW}");

           

            //Any Char
            //WeightCalc weightCalcDefault = new WeightCalc
            //{
            //    hight = 176,
            //    gender = 'Z'
            //};
            //double wightDefault = weightCalcDefault.GetWight();
            //Console.WriteLine($"Ideal wight for Zero ={wightDefault}");

            Console.ReadKey();


        }
    }
}
