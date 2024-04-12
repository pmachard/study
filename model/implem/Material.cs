
using Model.@interface;

namespace Model.implem
{
    public class Material : IMaterial
    {
        public Material()
        {
            C = new Color(1.0,1.0,1.0);
            Reflect = 0.0;
        }
        public IColor C { get ; set ; }
        public double Reflect { get ; set ; }
    }
}