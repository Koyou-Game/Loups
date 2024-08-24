namespace Sketches.Entities
{
    public interface ISketch
    {
        string ResourcePath { get; init; }
    }

    public abstract class Sketch : ISketch
    {
        public string ResourcePath { get; init; }
    }
}