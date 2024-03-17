using Math.@interface;
using Math.implem;
using Model.@interface;

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

        public void RemoveObject(IObject3D o)
        {
            _objects.Remove(o);
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

        public IEnumerator<IObject3D> GetEnumerator()
        {
            if (_objects != null)
                foreach (IObject3D object3D in _objects)
                {  yield return object3D; 
                }
            yield return null;
        }
    }
}
