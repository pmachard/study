using Math.@interface;
using Math.implem;
using Model.@interface;
using Model.nterface;

namespace Model.implem
{
    public class Scene : IScene
    {
        private List<IObject3D> _objects = new List<IObject3D>();

        public Scene() 
        {
            CS = new CoordSystem();
        }

        public ICoordSystem CS { get; set; }

        public void AddObject(IObject3D o)
        {
            _objects.Add(o);
        }

        public int NbrObjects()
        {
            return _objects.Count();
        }

        public IObject3D GetObject(int pos)
        {
            if (pos < 0 || pos >= _objects.Count())
                throw new ArgumentOutOfRangeException();

            return _objects[pos];
        }

    }
}