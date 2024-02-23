using Math.@interface;

namespace Model.@interface
{
    public interface IObject3D : ITranslatable
    {
        // repere local de l'object 3d
        public ICoordSystem LocalCoordSystem { get; set; }

    }
}
