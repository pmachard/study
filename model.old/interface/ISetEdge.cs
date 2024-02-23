interface ISetEdge : ITranslatable
{
    // Ensemble de point par default vide 
    public ISetEdge();
    // Ajout d'un point dans la liste des point
    public AddPoint(ICoord Pt);

    // Iterator sur les points
    public IEnumerator<ICoord3D> GetCoord();
};
