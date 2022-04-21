using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter 
    {
        public static void Printer(ArrayList steps, Product FinalProduct)
        {
            Console.WriteLine($"Receta de {FinalProduct.Description}:");
            foreach (Step step in steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}