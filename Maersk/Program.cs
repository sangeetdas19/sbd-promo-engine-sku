using System;
using System.Collections.Generic;
using System.Linq;

namespace Maersk
{
    class Program
    {
        static void Main(string[] args)
        {          
            //A          
            Console.WriteLine("Number of Product A added to cart: ");
            int a = Convert.ToInt32(Console.ReadLine());           
            List<string> productList = new List<string>();
            for (int i = 0; i < a; i++)
            {               
                    productList.Add("a");
            }
            //B          
            Console.WriteLine("Number of Product B added to cart: ");
            int b = Convert.ToInt32(Console.ReadLine());                
            for (int i = 0; i < b; i++)
            {               
                    productList.Add("b");
            }
            //C          
            Console.WriteLine("Number of Product C added to cart: ");
            int c = Convert.ToInt32(Console.ReadLine());            
            for (int i = 0; i < c; i++)
            {              
                    productList.Add("c");
            }
            //D         
            Console.WriteLine("Number of Product D added to cart: ");
            int d = Convert.ToInt32(Console.ReadLine());            
            for (int i = 0; i < d; i++)
            {               
                   productList.Add("d");
            }           
            int totalPrice = GetFinalCost(productList);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }

        private static int GetFinalCost(List<string> products)
        {
            int countA = 0;
            int costA = 50;
            int cost3ofA = 130;
            int countB = 0;
            int costB = 30;
            int cost2ofB = 45;
            int countC = 0;
            int costC = 20;
            int countD = 0;
            int costD = 15;

            int priceCandD = 30;

            foreach (string item in products)
            { 
                    if (item == "a")
                    {
                        countA = countA + 1;
                    }
                    if (item == "b")
                    {
                        countB = countB + 1;
                    }
                    if (item == "c")
                    {
                        countC = countC + 1;
                    }
                    if (item == "d")
                    {
                        countD = countD + 1;
                    }               
            }
            int totalCostofA = 0;
            if (countA >= 3)
            {
                int remainderofA = countA % 3;
                int divisorofA = countA / 3;
                totalCostofA = cost3ofA * divisorofA + remainderofA * costA;
            }
            else
            {
                totalCostofA = costA * countA;
            }

            int totalCostofB = 0;
            if (countB >= 2)
            {
                int reminderB = countB % 2;
                int divisionB = countB / 2;
                totalCostofB = cost2ofB * divisionB + reminderB * costB;
            }
            else
            {
                totalCostofB = costB * countB;
            }

            int totalCostofC = 0;
            if (countC >= 1)
            {
                totalCostofC = costC;
            }

            int totalCostofD = 0;
            if (countD >= 1 && countC >= 1)
            {
                totalCostofD = priceCandD;
                totalCostofC = 0;
            }
            else if (countD >= 1)
            {
                totalCostofD = costD;
              
            }
            int totalCost = totalCostofA + totalCostofB + totalCostofC + totalCostofD;
            return totalCost;
        }        
    }
}
