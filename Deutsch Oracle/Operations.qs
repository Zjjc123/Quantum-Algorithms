namespace Deutsch_Oracle
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;

    // By keeping the input --> operation is reversible thus making 
    // it quantumly possible

    // Output 0 ---> | Black | ---> f(x)
    // Input  x ---> |  Box  | ---> x

    // Determine whether the black box is constant or variable with a single query
    // Require 2 query for a classical computer 
    // Quantum supremacy?

    // Test the problem:
    // Output 0 --> X ---> H ---> | Black | ---> H ---> Measure
    // Input  0 --> X ---> H ---> |  Box  | ---> H ---> Measure

    // if the output is 11 --> function is constant
    // if the output is 10 --> function is variable

    // Returns true if constant and returns false if variable
    operation IsBlackBoxConstant(blackBox: ((Qubit, Qubit) => ())) : (Bool)
    {
        body
        {
            // Initialize results
            // By default --> Q# variables are immutable
            mutable inputResult = Zero;
            mutable outputResult = Zero;

            // Allocate two qbits
            // All qubits are dynamically allocated and released
            using (qbits = Qubit[2])
            {
                // set one as input and the other as output
                // binding of an immutable variable
                let input = qbits[0];
                let output = qbits[1];

                // set both to zero 
                Clear(input, output);

                // bitflip
                X(input);
                X(output);

                // Hadamard --> superposition
                H(input);
                H(output);

                // send qbits into black box 
                blackBox(input, output);

                // Hadamard --> out of superposition
                H(input);
                H(output);

                // measure outputs
                // changes the value of a mutable variable
                set inputResult = M(input);
                set outputResult = M(output);

                // clear qbits before release
                Clear(input, output);
            }

            // 1 (1) ---> input is 1 so bb is constant
            // 1 (0) ---> input is 0 so bb is variable
            return One == inputResult;
        }
    }


    // Operations for running
    operation IsConstantZeroConstant(): (Bool)
    {
        body
        {
            return IsBlackBoxConstant(ConstantZero);
        }
    }
    operation IsConstantOneConstant(): (Bool)
    {
        body
        {
            return IsBlackBoxConstant(ConstantOne);
        }
    }
    operation IsIdentityConstant(): (Bool)
    {
        body
        {
            return IsBlackBoxConstant(Identity);
        }
    }
    operation IsNegationConstant(): (Bool)
    {
        body
        {
            return IsBlackBoxConstant(Negation);
        }
    }


    // Set qubit to desired state
    operation Set(desired : Result, q1 : Qubit) : Unit 
    {
        if (desired != M(q1)) {
            X(q1);
        }
    }

    operation Clear(q1: Qubit, q2: Qubit) : Unit
    {
        Set(Zero, q1);
        Set(Zero, q2);
    }
}
