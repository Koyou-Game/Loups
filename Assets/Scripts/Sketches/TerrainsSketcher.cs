using System;
using System.Collections.Generic;
using System.Linq;
using Sketches.Entities;
using UnityEngine;

namespace Sketches
{
    public class TerrainsSketcher : ContainerSketcher
    {
        public override ISketch SceneToSketch()
        {
            var sketchers = new List<Sketcher>();
            // 遍历 root 的直接子物体（不包括更深层次的子物体）
            foreach (Transform child in transform)
            {
                var childSketcher = child.GetComponent<Sketcher>();
                if (childSketcher == null) continue;
                sketchers.Add(childSketcher);
            }

            return new TerrainsSketch
            {
                Sketches = sketchers.Select(sketcher => sketcher.SceneToSketch()).ToList(),
            };
        }

        public override void SketchToScene(ISketch sketch)
        {
            var terrainsSketch = (ITerrainsSketch)sketch;
            var sketches = terrainsSketch.Sketches;
            // // 遍历 root 的直接子物体（不包括更深层次的子物体）
            // foreach (Transform child in transform)
            // {
            //     var childSketcher = child.GetComponent<Sketcher>();
            //     if (childSketcher != null)
            //     {
            //         Destroy(child.gameObject);
            //     }
            // }

            foreach (var terrainSketch in sketches)
            {
                var terrainSketcher = ChileSketchToScene(terrainSketch);
            }
        }

        private Sketcher ChileSketchToScene(ISketch terrainSketch)
        {
            switch (terrainSketch)
            {
                case IShapeSketch shapeSketch:
                    return ShapeSketcher.Generate(shapeSketch, transform);
                default:
                    throw new ArgumentOutOfRangeException(nameof(terrainSketch));
            }
        }
    }
}