interface ICylinder : IObject3D
{
  // constructeur par default du cylindre 1.0 * 1.0
  public ICylinder();
  // constructeur avec le repère local et le rayon et la hauteur
  public ICylinder(ICoordSystem localCoordSystem, double radius, double height);

  // rayon du cylindre
  public double Radius {get;set;}
  // hauteur du cylindre
  public double Height {get;set;}
  // repere du cylindre
  public ICoordSystem LocalCoordSystem {get; set;};

}
