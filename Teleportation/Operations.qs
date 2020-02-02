namespace Teleportation
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;


    operation TestTeleportation(State: Int) : Int
    {
        using (qbits = Qubit[2])
        {
            mutable result = Zero;

            // bind both qubits
            let A = qbits[0];
            let B = qbits[1];

            Clear(A, B);

            if (State == 1)
            {
                Set(One, A);
            }

            // Teleport A to C
            Teleport(A, B);

            // Now B should be the same as A

            set result = M(B);

            // Ensure qubits are 0 before release
            Reset(qbits[0]);
            Reset(qbits[1]);

            mutable r = 0;
            
            if (result == One)
            {
                set r = 1;
            }

            return r;

        }
    }


    // Teleportation
    operation Teleport (SendQubit: Qubit, RecieveQubit: Qubit) : Unit
    {
        using (qbits = Qubit[1])
        {
            // Initialize results
            // By default --> Q# variables are immutable
            mutable cResult = Zero;
            mutable aResult = Zero;

            // bind both qubits
            let A = qbits[0];

            // Set both to 0
            Clear(A, RecieveQubit);

            // Create bell state
            Entangle(A, RecieveQubit);

            // Transport B away

            // Apply adjoint of bell to convert first tensor product
            // to classical states
            CNOT(SendQubit, A);
            H(SendQubit);
            
            // Measure results
            set cResult = M(SendQubit);
            set aResult = M(A);
            
            // Last conversion step to teleport B to C
            if (cResult == One)
            {
                Z(RecieveQubit);
            }
            if (aResult == One)
            {
                X(RecieveQubit);
            }

            // Ensure qubit is 0 before release
            Reset(qbits[0]);

        }
        
    }

    // Entangle two qubits
    operation Entangle (Qubit1: Qubit, Qubit2: Qubit) : Unit
    {
        H(Qubit1);
        CNOT(Qubit1, Qubit2);
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
