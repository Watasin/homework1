using System;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            while (check != true)
            {
                Console.Write("Input Number : ");
                int row = int.Parse(Console.ReadLine());
                if (row >= 0)
                {
                    Row(row);
                    check = true;
                }
                else
                    Console.WriteLine("Invalid Pascal’s triangle row number.");
            }
        }
        
