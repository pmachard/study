using Math.@interface;
using Math.implem;
using Model.@interface;
using Model.nterface;

namespace Model.implem
{

    class SetEdge : ISetEdge
    {
        private List<ICoord3D> Coords;

        public SetEdge()
        {
            Coords = new List<ICoord3D>();
        }

        public void AddPoint(ICoord3D Pt)
        {
            Coords.Add(Pt);
        }

        public IEnumerator<ICoord3D> GetCoord()
        {
            foreach (ICoord3D coord in Coords) { yield return coord; }
        }

        public void RunTranlation(ICoord3D v)
        {
            List<ICoord3D> newList = new List<ICoord3D>();
            foreach (ICoord3D coord in Coords)
            {
                newList.Add(coord + v);
            }
            Coords = newList;
        }
    };
}