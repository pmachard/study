﻿
using Math.@interface;
using Math.implem;
using Model.@interface;

namespace Model.implem
{
    public class Light : ILight
    {
        public Light()
        {
            CS = new CoordSystem();
            Color = new Color(1.0,1.0,1.0);
            V = new Coord3D(1.0, 1.0, 1.0);
        }

        // repére origine de la lumiere
        public ICoordSystem CS { get; set; }
        // Couleur de la lumiere
        public IColor Color { get; set; }
        // vecteur directeur de la lumiere
        public ICoord3D V { get; set; }
    }
}