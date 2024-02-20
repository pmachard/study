// Rayon utilisé dans l'algo du raytracing
interface IRay : IObject3D
{
  // constructeur par default du rayon
  public IRay();
  // constructeur avec initialisation du rayon
  public IRay(ICoord3D o, ICoord3D v);

  // origine du rayon
  public ICoord3D O { get; set; };
  // vecteur directeur du rayon
  public ICoord3D V { get; set; };

}
