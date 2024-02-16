interface ICoordSystem : ITranslatable
{
    // Création d'un repère par default
    public ICoord3D();
    // Création d'un repère o i j k
    public ICoord3D(ICoord3D o,ICoord3D i,ICoord3D j,ICoord3D k);

    // Centre du repère
    public ICoord3d O {get; set;};
    // Vecteur X
    public ICoord3d I {get; set;};
    // Vecteur Y
    public ICoord3d J {get; set;};
    // Vecteur Z
    public ICoord3d K {get; set;};
}
