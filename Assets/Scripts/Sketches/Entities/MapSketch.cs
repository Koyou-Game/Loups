namespace Sketches.Entities
{
    public interface IMapSketch : ISketch
    {
        ITerrainsSketch TerrainsSketch { get; init; }
        IInteractionsSketch InteractionsSketch { get; init; }
    }

    public class MapSketch : Sketch, IMapSketch
    {
        public ITerrainsSketch TerrainsSketch { get; init; }
        public IInteractionsSketch InteractionsSketch { get; init; }
    }
}