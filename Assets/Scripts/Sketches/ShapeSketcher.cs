using Sketches.Entities;
using UnityEngine;

namespace Sketches
{
    public class ShapeSketcher : PlacementSketcher
    {
        [SerializeField] private SpriteRenderer sr;
        [SerializeField] private new Collider2D collider;

        public override ISketch ToSketch()
        {
            // todo
            return new ShapeSketch();
        }
    }
}