interface ICylinder : IObject3D
{
  public ICylinder();
  public ICylinder(double radius, double height);
  
  public double Radius {get;set;}
  public double Height {get;set;}
  public ICoordSystem LocalCoordSystem {get; set;};

}
