using Math.@interface;
using Model.@interface;

namespace Model.@nterface
{
    public interface ISetEdge : ITranslatable
    {
        // Ajout d'un point dans la liste des point
        public void AddPoint(ICoord3D Pt);

        // Iterator sur les points
        public IEnumerator<ICoord3D> GetCoord();
    };

}