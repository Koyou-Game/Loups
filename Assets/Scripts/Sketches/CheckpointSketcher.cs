using Sketches.Entities;
using UnityEngine;

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

        #region CheckpointSketcher

        private static CheckpointSketcher sPrefab;

        public static Sketcher Generate(ICheckpointSketch sketch, Transform parent)
        {
            sPrefab ??= Resources.Load<CheckpointSketcher>(sketch.ResourcePath);

            var shapeSketcher = Instantiate(sPrefab, sketch.Position, Quaternion.identity, parent);
            return shapeSketcher;
        }

        #endregion
    }
}