interface ISphere : IObject3D
{
  public ISphere();
  public ISphere(ICoordSystem cs, double r);
  
  public double Radius(get;set);
  public ICoordSystem LocalCoordSystem {get; set;};
  
  public RunTranlation(ICoord3D v)
  {
      coordSystem.RunTranslation(v);
  }
  
}
