using System.Collections.Generic;
using Newtonsoft.Json;

namespace Sketches.Entities
{
    public interface IInteractionsSketch : IPlacementSketch
    {
        List<ISketch> Sketches { get; init; }
    }

    public class InteractionsSketch : PlacementSketch, IInteractionsSketch
    {
        [JsonProperty(TypeNameHandling = TypeNameHandling.All)]
        public List<ISketch> Sketches { get; init; }
    }
}