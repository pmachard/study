using Math.@interface;
using Model.@interface;

namespace Model.@nterface
{
    interface IRotable
    {
        // operation de translation
        public void RunRotXoX(ICoord3D o, double a);
        public void RunRotYoY(ICoord3D o, double a);
        public void RunRotZoZ(ICoord3D o, double a);
    }

}