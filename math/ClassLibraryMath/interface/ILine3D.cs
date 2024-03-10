
namespace Math.@interface
{
    public interface ILine3D
    {
         public ICoord3D O{get;set;}
         public ICoord3D V{get;set;}
         
         public double Compute(ICoord3D pt);
         public bool In(ICoord3D pt);
         public ICoord3D Intersection(ILine3D line);
    }
}