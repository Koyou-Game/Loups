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
        [SerializeField] private static ShapeSketcher sPrefab;

        [SerializeField] private SpriteRenderer sr;
        [SerializeField] private new Collider2D collider;

        public static Sketcher Generate(IShapeSketch shapeSketch, Transform parent)
        {
            sPrefab ??= Resources.Load<ShapeSketcher>(shapeSketch.ResourcePath);

            var shapeSketcher = Instantiate(sPrefab, shapeSketch.Position, Quaternion.identity, parent);
            return shapeSketcher;
        }

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
    }
}