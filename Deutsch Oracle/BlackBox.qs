namespace Deutsch_Oracle
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;

    // Black box implementation of reversible single bit operations

    // ConstantZero operation: do nothing (because 0 is the what goes into the black
    // box as the output)
    // Unit for "void"
    operation ConstantZero(input: Qubit, output: Qubit): (Unit)
    {
        body
        {

        }
    }

    // ConstantOne operation: bit flip
    // (because 0 is the what goes into the black
    // box as the output --> so bitflipping would make the output 1)
    operation ConstantOne(input: Qubit, output: Qubit): (Unit)
    {
        body
        {
            X(output);
        }
    }

    // Identity operation: CNOT
    // Input as the control bit and output as the target bit
    // If input bit is 1 --> output bit is set to 1
    // If input bit is 0 --> output bit is set to 0
    operation Identity(input: Qubit, output: Qubit): (Unit)
    {
        body
        {
            CNOT(input, output);
        }
    }

    // Identity operation: CNOT then Bitflip
    // Input as the control bit and output as the target bit
    // If input bit is 1 --> output bit is set to 1
    // If input bit is 0 --> output bit is set to 0
    // Then bits are flipped to get the negative
    operation Negation(input: Qubit, output: Qubit): (Unit)
    {
        body
        {
            CNOT(input, output);
            X(output);
        }
    }
}