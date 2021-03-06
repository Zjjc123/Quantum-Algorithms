// <auto-generated>
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Superdense_Coding\",\"Name\":\"SendMessage\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"firstBit\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":32}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"secondBit\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":48}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Superdense_Coding\",\"Name\":\"SendMessage\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Superdense_Coding\",\"Name\":\"Set\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs\",\"Position\":{\"Item1\":78,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"desired\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":15},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q1\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":35}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Superdense_Coding\",\"Name\":\"Set\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs\",\"Position\":{\"Item1\":78,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Superdense_Coding\",\"Name\":\"Clear\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs\",\"Position\":{\"Item1\":86,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q1\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":19}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q2\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":30}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Superdense_Coding\",\"Name\":\"Clear\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs\",\"Position\":{\"Item1\":86,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
#line hidden
namespace Superdense_Coding
{
    [SourceLocation("C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs", OperationFunctor.Body, 6, 79)]
    public partial class SendMessage : Operation<(Int64,Int64), (Int64,Int64)>, ICallable
    {
        public SendMessage(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Int64,Int64)>, IApplyData
        {
            public Out((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "SendMessage";
        String ICallable.FullName => "Superdense_Coding.SendMessage";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicZ
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Qubit), QVoid> Clear
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), (Int64,Int64)> Body => (__in__) =>
        {
            var (firstBit,secondBit) = __in__;
#line 10 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
            var aResult = Result.Zero;
#line 11 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
            var bResult = Result.Zero;
#line hidden
            {
#line 13 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
                var qbits = Allocate.Apply(2L);
#line hidden
                System.Runtime.ExceptionServices.ExceptionDispatchInfo __arg1__ = null;
                try
                {
#line 17 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
                    var A = qbits[0L];
#line 18 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
                    var B = qbits[1L];
#line 21 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
                    Clear.Apply((A, B));
#line 24 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
                    MicrosoftQuantumIntrinsicH.Apply(A);
#line 28 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((A, B));
#line 34 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
                    if ((secondBit == 1L))
                    {
#line 36 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
                        MicrosoftQuantumIntrinsicX.Apply(A);
                    }

#line 38 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
                    if ((firstBit == 1L))
                    {
#line 40 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
                        MicrosoftQuantumIntrinsicZ.Apply(A);
                    }

#line 49 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((A, B));
#line 50 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
                    MicrosoftQuantumIntrinsicH.Apply(A);
#line 53 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
                    aResult = MicrosoftQuantumIntrinsicM.Apply(A);
#line 54 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
                    bResult = MicrosoftQuantumIntrinsicM.Apply(B);
#line 57 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
                    Clear.Apply((A, B));
#line 59 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
                    var aMessage = 0L;
#line 60 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
                    var bMessage = 0L;
#line 62 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
                    if ((aResult == Result.One))
                    {
#line 64 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
                        aMessage = 1L;
                    }

#line 66 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
                    if ((bResult == Result.One))
                    {
#line 68 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
                        bMessage = 1L;
                    }

#line 71 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
                    return (aMessage, bMessage);
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(__arg2__);
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        __arg1__.Throw();
                    }

#line hidden
                    Release.Apply(qbits);
                }
            }
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumIntrinsicZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Z));
            this.Clear = this.Factory.Get<ICallable<(Qubit,Qubit), QVoid>>(typeof(Clear));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut((Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64)> Run(IOperationFactory __m__, Int64 firstBit, Int64 secondBit)
        {
            return __m__.Run<SendMessage, (Int64,Int64), (Int64,Int64)>((firstBit, secondBit));
        }
    }

    [SourceLocation("C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs", OperationFunctor.Body, 79, 87)]
    public partial class Set : Operation<(Result,Qubit), QVoid>, ICallable
    {
        public Set(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,Qubit)>, IApplyData
        {
            public In((Result,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "Set";
        String ICallable.FullName => "Superdense_Coding.Set";
        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(Result,Qubit), QVoid> Body => (__in__) =>
        {
            var (desired,q1) = __in__;
#line 81 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
            if ((desired != MicrosoftQuantumIntrinsicM.Apply(q1)))
            {
#line 82 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
                MicrosoftQuantumIntrinsicX.Apply(q1);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((Result,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Result desired, Qubit q1)
        {
            return __m__.Run<Set, (Result,Qubit), QVoid>((desired, q1));
        }
    }

    [SourceLocation("C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs", OperationFunctor.Body, 87, -1)]
    public partial class Clear : Operation<(Qubit,Qubit), QVoid>, ICallable
    {
        public Clear(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit)>, IApplyData
        {
            public In((Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "Clear";
        String ICallable.FullName => "Superdense_Coding.Clear";
        protected ICallable<(Result,Qubit), QVoid> Set
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit), QVoid> Body => (__in__) =>
        {
            var (q1,q2) = __in__;
#line 89 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
            Set.Apply((Result.Zero, q1));
#line 90 "C:/Users/zjjc1/Desktop/Quantum-Algorithms/Superdense%20Coding/Operations.qs"
            Set.Apply((Result.Zero, q2));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Set = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Set));
        }

        public override IApplyData __dataIn((Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q1, Qubit q2)
        {
            return __m__.Run<Clear, (Qubit,Qubit), QVoid>((q1, q2));
        }
    }
}