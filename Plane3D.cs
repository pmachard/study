class Plane3D : IPlane3D
{
  public Plane3D()
  {
    O = new Coord3D();
    V = new Coord3D();
  }
  
  public ICoord3D O {get;set;}
  public ICoord3D V {get;set;}
  
};
