using System;
using Math.@interface;

namespace Math.implem
{ 

    public class Coord3D : ICoord3D, IEquatable<Coord3D>
    {
        public Coord3D()
        {
            X = Y = Z = 0.0;
        }

        public Coord3D(double x, double y, double z)
        {
            X = x; Y = y; Z = z;
        }

        public Coord3D(ICoord3D other)
        {
            X = other.X; 
            Y = other.Y; 
            Z = other.Z;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }


        public ICoord3D operator_add(ICoord3D b)
        {
            return new Coord3D(X + b.X, Y + b.Y, Z + b.Z);
        }

        public ICoord3D operator_supp(ICoord3D b)
        {
            return new Coord3D(X - b.X, Y - b.Y, Z - b.Z);
        }

        public ICoord3D operator_supp()
        {
            return new Coord3D(-X, -Y, -Z);
        }

        public ICoord3D operator_mult(ICoord3D b)
        {
            return new Coord3D(X * b.X, Y * b.Y, Z * b.Z);
        }

        public ICoord3D operator_mult(double b)
        {
            return new Coord3D(X * b, Y * b, Z * b);
        }

        public ICoord3D operator_div(ICoord3D b)
        {
            return new Coord3D(X / b.X, Y / b.Y, Z / b.Z);
        }

        public ICoord3D operator_div(double b)
        {
            return new Coord3D(X / b, Y / b, Z / b);
        }

        public double operator_scal(ICoord3D b)
        {
            return X / b.X + Y / b.Y + Z / b.Z;
        }

        public bool IsProportional(ICoord3D other)
        {
            if (other.X == 0.0 && X != 0)
                return false;
            if (other.Y == 0.0 && Y != 0)
                return false;
            if (other.Z == 0.0 && Z != 0)
                return false;

            double tx = other.X != 0.0 ? X / other.X : 0.0;
            double ty = other.Y != 0.0 ? Y / other.Y : 0.0;
            double tz = other.Z != 0.0 ? Z / other.Z : 0.0;

            if (tx == ty && ty == tz && tz == 0.0)
                return true;
            if (tx == 0.0)
                return ty == tz;
            if (ty == 0.0)
                return tx == tz;
            if (tz == 0.0)
                return tx == ty;

            return tx == ty && tx == tz;
        }

        public ICoord3D swap()
        {
            return new Coord3D(Z, Y, X);
        }

        public ICoord3D operator_produit_vect(ICoord3D b)
        {
            return new Coord3D(Y * b.Z - Z * b.Y,
                               Z * b.X - X * b.Z,
                               X * b.Y - Y * b.X);
        }

        public bool Equals(Coord3D? other)
        {
            return  X == other.X && 
                    Y == other.Y && 
                    Z == other.Z;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Coord3D)) return false;
            return Equals((Coord3D)obj);
        }
        public double Norme()
        {
            return math.Sqrt(X * X + Y * Y + Z * Z);
        }
    };
}