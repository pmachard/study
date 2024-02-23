interface ICube : IObject3D
{
  // Constructeur par default du cube 1.0
  public ICube();
  // Constructeur qui initialise le repère et la size
  public ICube(ICoordSystem coordSystem, double size);
  // size du cube
  public double Size(get;set);
  // exemple de commit
}
