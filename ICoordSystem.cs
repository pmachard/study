interface ICoordSystem : ICoord3D
{
    public ICoord3D();
    public ICoord3D(ICoord3D o,ICoord3D i,ICoord3D j,ICoord3D k);
  
    public ICoord3d O {get; set;};
    public ICoord3d I {get; set;};
    public ICoord3d J {get; set;};
    public ICoord3d K {get; set;};

  
}
