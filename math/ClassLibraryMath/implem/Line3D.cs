using Math.@Interface;
namespace Math.@Implem
{
    public class Line3D : ILine3D
    {
         public ICoord3D O{get;set;}
         public ICoord3D V{get;set;}
         
         public double Compute(Icoord3D pt) 
         {
              return 0.0; 
         }
         public bool In(ICoord3D pt) 
         {
              return False;
         }
         public ICoord3D Intersection(ILine line)
         {
              return new Coord3D();
         }
    }
}