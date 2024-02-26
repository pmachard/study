using Math.@interface;
using Math.implem;

using Model.@interface;
using Model.nterface;

namespace Model.implem
{
    public class Line3D : ILine3D
    {
      public Line3D()
      {
        O = new Coord3D();
        V = new Coord3D();    
      }
  
      public ICoord3D O { get; set; }
      public ICoord3D V { get; set; }

      public bool IsParallel(ILine3D other)
      {    
        return V.IsProportional(other.V);
      }
  
      public bool IsPerpendicular(ILine3D other)
      {
        double produitScalaire = V ^ other.V;
        // cela ne sufffit passss
        return produitScalaire == 0.0;
      }

      public bool IsSecant(ILine3D other)
      {    
        if (this.IsParallel(other))
          return false;

            // cela ne sufffit passss

            return true;
      }

      public ICoord3D Intersect(ILine3D other)
      {  
        if (!IsSecant(other))
          return new Coord3D(double.NaN, double.NaN, double.NaN);

        ICoord3D result = new Coord3D();
    
        return result;
      }

      public bool In(ICoord3D pt)
      {
        return V.IsProportional(pt - O);
      }

    }
}