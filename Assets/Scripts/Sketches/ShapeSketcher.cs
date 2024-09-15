using Koyou.Commons;
using Sketches.Entities;
using UnityEngine;

namespace Sketches
{
    /// <summary>
    /// todo 先不全转成 json， 而是用 template 的方式
    /// </summary>
    public class ShapeSketcher : PlacementSketcher
    {
        #region PlacementSketcher

        public override ISketch SceneToSketch()
        {
            return new ShapeSketch
            {
                ResourcePath = resourcePath,
                Position = transform.localPosition,
            };
        }

        public override void SketchToScene(ISketch sketch)
        {
            Log.N($"TODO"); // todo
        }

        #endregion

        #region ShapeSketcher

        private static ShapeSketcher sPrefab;

        [SerializeField] private SpriteRenderer sr;
        [SerializeField] private new Collider2D collider;

        public static Sketcher Generate(IShapeSketch sketch, Transform parent)
        {
            sPrefab ??= Resources.Load<ShapeSketcher>(sketch.ResourcePath);

            var shapeSketcher = Instantiate(sPrefab, sketch.Position, Quaternion.identity, parent);
            return shapeSketcher;
        }

        #endregion
    }
}