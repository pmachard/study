using Math.@interface;
using Math.implem;
using Model.@interface;
using Model.nterface;

namespace Model.implem
{
    class Edge : IEdge
    {
        public Edge()
        {
            A = B = new Coord3D();
        }
        public Edge(ICoord3D a, ICoord3D b)
        {
            A = a;
            B = b;
        }

        public ICoord3D A { get; set; }
        public ICoord3D B { get; set; }

        public void RunTranlation(ICoord3D v)
        {
            A = A + v;
            B = B + v;
        }

    }

}