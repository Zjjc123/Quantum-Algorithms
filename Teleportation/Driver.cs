using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Teleportation
{
    class Driver
    {
        static void Main(string[] args)
        {
             using (var qsim = new QuantumSimulator())
            {
                Console.WriteLine("Enter Start State (0, 1)): ");
                int a = int.Parse(Console.ReadLine());

                var res = TestTeleportation.Run(qsim, a).Result;
                var state = res;
                                
                Console.WriteLine("Result: " + state);
            }
        }
    }
}