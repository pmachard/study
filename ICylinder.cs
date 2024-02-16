interface ICylinder : IObject3D
{
  public ICylinder();
  public ICylinder(ICoordSystem localCoordSystem, double radius, double height);
  
  public double Radius {get;set;}
  public double Height {get;set;}
  public ICoordSystem LocalCoordSystem {get; set;};

}
