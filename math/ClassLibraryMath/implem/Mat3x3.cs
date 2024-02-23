using Math.@interface;

namespace Math.implem
{
    public class Mat3x3 : IMat
    {
        public int N { get ; set ; }
        public int M { get ; set ; }

        private double _m11, _m12, _m13;
        private double _m21, _m22, _m23;
        private double _m31, _m32, _m33;

        public Mat3x3()
        {
            N = 3;
            M = 3;

            this._m11 = this._m12 = this._m13 = 0.0;
            this._m21 = this._m22 = this._m23 = 0.0;
            this._m31 = this._m32 = this._m33 = 0.0;
        }

        public static IMat Unit()
        {
            Mat3x3 result = new Mat3x3();

            result._m11 = 1.0;
            result._m22 = 1.0;
            result._m33 = 1.0;

            return result;
        }


        public double get(int m,int n)
        {
            if ((m == 1) && (n == 1)) return this._m11;
            if ((m == 1) && (n == 2)) return this._m12;
            if ((m == 1) && (n == 3)) return this._m13;

            if ((m == 2) && (n == 1)) return this._m21;
            if ((m == 2) && (n == 2)) return this._m22;
            if ((m == 2) && (n == 3)) return this._m23;

            if ((m == 3) && (n == 1)) return this._m31;
            if ((m == 3) && (n == 2)) return this._m32;
            if ((m == 3) && (n == 3)) return this._m33;

            return Double.NaN;
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