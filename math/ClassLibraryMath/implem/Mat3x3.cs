using Math.@interface;

namespace Math.implem
{
    internal class Mat3x3 : IMat
    {
        public int M { get{return 3;}}
        public int N { get{return 3;}}

        int IMat.N { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IMat.M { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double get(int m,int n)
        {
          return (double) 0.0;
        }

        public IMat operator_add(IMat b)
        {
            throw new NotImplementedException();
        }

        public IMat operator_div(IMat b)
        {
            throw new NotImplementedException();
        }

        public IMat operator_div(double b)
        {
            throw new NotImplementedException();
        }

        public IMat operator_mult(IMat b)
        {
            throw new NotImplementedException();
        }

        public IMat operator_mult(double b)
        {
            throw new NotImplementedException();
        }

        public IMat operator_supp(IMat b)
        {
            throw new NotImplementedException();
        }
    };
}