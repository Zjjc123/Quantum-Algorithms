using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Deutsch_Oracle
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                Console.WriteLine($"ConstantZero constant: [{IsConstantZeroConstant.Run(qsim).Result}]");
                Console.WriteLine($"ConstantOne constant: [{IsConstantOneConstant.Run(qsim).Result}]");
                Console.WriteLine($"Identity constant: [{IsIdentityConstant.Run(qsim).Result}]");
                Console.WriteLine($"Negation constant: [{IsNegationConstant.Run(qsim).Result}]");
            }

            Console.ReadKey();
        }
    }
}