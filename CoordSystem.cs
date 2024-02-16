class CoordSystem : ICoordSystem
{
    public Coord3D()
    {
      O = new Coord3D(0.0,0.0,0.0);
      I = new Coord3D(1.0,0.0,0.0);
      J = new Coord3D(0.0,1.0,0.0);
      K = new Coord3D(0.0,0.0,1.0);
    }

    public ICoord3D(ICoord3D o,ICoord3D i,ICoord3D j,ICoord3D k)
    {
      O = new Coord3D(o);
      I = new Coord3D(i);
      J = new Coord3D(j);
      K = new Coord3D(k);
    }
  
    public ICoord3d O {get; set;};
    public ICoord3d I {get; set;};
    public ICoord3d J {get; set;};
    public ICoord3d K {get; set;};

    public RunTranlation(ICoord3D v)
    {
        O = O + v;
    }
}
