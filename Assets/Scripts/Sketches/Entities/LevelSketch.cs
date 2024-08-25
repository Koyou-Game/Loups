namespace Sketches.Entities
{
    public interface ILevelSketch : ISketch
    {
        IMapSketch MapSketch { get; init; }
    }

    public class LevelSketch : Sketch, ILevelSketch
    {
        public IMapSketch MapSketch { get; init; }
    }
}