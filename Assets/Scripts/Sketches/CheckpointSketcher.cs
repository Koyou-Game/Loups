using Sketches.Entities;

namespace Sketches
{
    public class CheckpointSketcher : PlacementSketcher
    {
        #region PlacementSketcher

        public override ISketch SceneToSketch()
        {
            return new CheckpointSketch
            {
                ResourcePath = resourcePath,
                Position = transform.localPosition,
            };
        }

        public override void SketchToScene(ISketch sketch) { }

        #endregion
    }
}