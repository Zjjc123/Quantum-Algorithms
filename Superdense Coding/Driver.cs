using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Superdense_Coding
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                Console.WriteLine("Enter First Bit (0 or 1): ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Bit (0 or 1): ");
                int b = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Result: ");
                Console.WriteLine(SendMessage.Run(qsim, a, b).Result);
            }
        }
    }
}