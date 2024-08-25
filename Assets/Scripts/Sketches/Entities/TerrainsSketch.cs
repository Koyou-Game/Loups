using System.Collections.Generic;
using Newtonsoft.Json;

namespace Sketches.Entities
{
    public interface ITerrainsSketch : IPlacementSketch
    {
        List<ISketch> Sketches { get; init; }
    }
    public class TerrainsSketch : PlacementSketch, ITerrainsSketch
    {
        [JsonProperty(TypeNameHandling = TypeNameHandling.All)]
        public List<ISketch> Sketches { get; init; }
    }
}