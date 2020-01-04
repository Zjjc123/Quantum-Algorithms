namespace Superdense_Coding
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;

    operation SendMessage (firstBit: Int, secondBit: Int) : (Int, Int) 
    {
        // Initialize results
        // By default --> Q# variables are immutable
        mutable aResult = Zero;
        mutable bResult = Zero;

        using (qbits = Qubit[2])
        {
            // set one as input and the other as output
            // binding of an immutable variable
            let A = qbits[0];
            let B = qbits[1];

            // Clear both qubits
            Clear(A, B);

            // Hadamard first qubit
            H(A);

            // Get into bell state |B00> by using CNOT with 
            // A(0) controlling targetB(0)
            CNOT(A, B);

            // Dependent on what the message that want to be sent is 
            // Apply X and Z gates
            // To get into the correct bell states

            if (secondBit == 1)
            {
                X(A);
            }
            if (firstBit == 1)
            {
                Z(A);
            }

            // Transport A LIGHT YEARS AWAY HAHAHA

            // Apply adjoint of Bell to undo bell state to get the message
            // equal to appying CNOT and Hadamard again (since both are self adjoint)
            // (inverse of itself)

            CNOT(A, B);
            H(A);

            // Read Message
            set aResult = M(A);
            set bResult = M(B);

            // Clear before release
            Clear(A, B);

            mutable aMessage = 0;
            mutable bMessage = 0;
            
            if (aResult == One)
            {
                set aMessage = 1;
            }
            if (bResult == One)
            {
                set bMessage = 1;
            }

            return (aMessage, bMessage);
        }
            
        
    }


    // Set qubit to desired state
    operation Set(desired : Result, q1 : Qubit) : Unit 
    {
        if (desired != M(q1)) {
            X(q1);
        }
    }

    // Clear qubits
    operation Clear(q1: Qubit, q2: Qubit) : Unit
    {
        Set(Zero, q1);
        Set(Zero, q2);
    }
}
