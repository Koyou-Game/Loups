using System.Collections.Generic;
using System.Linq;
using Sketches.Entities;
using UnityEngine;

namespace Sketches
{
    public class TerrainsSketcher : PlacementSketcher
    {
        public override ISketch SceneToSketch()
        {
            var sketchers = new List<Sketcher>();
            // 遍历 root 的直接子物体（不包括更深层次的子物体）
            foreach (Transform child in transform)
            {
                var childSketcher = child.GetComponent<Sketcher>();
                if (childSketcher != null)
                {
                    sketchers.Add(childSketcher);
                }
            }

            return new TerrainsSketch
            {
                Sketches = sketchers.Select(sketcher => sketcher.SceneToSketch()).ToList(),
            };
        }
    }
}