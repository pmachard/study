using Math.@interface;
using System.Formats.Asn1;

namespace Math.implem
{
    public class CoordSystem : ICoordSystem, IEquatable<CoordSystem>
    {
        public CoordSystem()
        {
            O = new Coord3D(0.0, 0.0, 0.0);
            I = new Coord3D(1.0, 0.0, 0.0);
            J = new Coord3D(0.0, 1.0, 0.0);
            K = new Coord3D(0.0, 0.0, 1.0);
        }

        public CoordSystem(ICoord3D o, ICoord3D i, ICoord3D j, ICoord3D k)
        {
            O = new Coord3D(o);
            I = new Coord3D(i);
            J = new Coord3D(j);
            K = new Coord3D(k);
        }

        public ICoord3D O { get; set; }
        public ICoord3D I { get; set; }
        public ICoord3D J { get; set; }
        public ICoord3D K { get; set; }

        public bool Equals(CoordSystem? other)
        {
            return ((O.Equals(other.O)) && 
                    (I.Equals(other.I))&& 
                    (J.Equals(other.J)) && 
                    (K.Equals(other.K)));
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(CoordSystem)) return false;
            return Equals((CoordSystem)obj);
        }

        public void RunTranlation(ICoord3D v)
        {
            O = O + v;
        }
    }
}