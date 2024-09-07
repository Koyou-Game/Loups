using Sketches.Entities;
using UnityEngine;

namespace Sketches
{
    /// <summary>
    /// todo 先不全转成 json， 而是用 template 的方式
    /// </summary>
    public class ShapeSketcher : PlacementSketcher
    {
        [SerializeField] private SpriteRenderer sr;
        [SerializeField] private new Collider2D collider;

        public override ISketch SceneToSketch()
        {
            return new ShapeSketch
            {
                ResourcePath = resourcePath,
                Position = transform.localPosition,
            };
        }
    }
}