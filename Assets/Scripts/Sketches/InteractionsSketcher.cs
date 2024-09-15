using System;
using System.Collections.Generic;
using System.Linq;
using Sketches.Entities;
using UnityEngine;

namespace Sketches
{
    public class InteractionsSketcher : ContainerSketcher
    {
        #region PlacementSketcher

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

            return new InteractionsSketch
            {
                Sketches = sketchers.Select(sketcher => sketcher.SceneToSketch()).ToList(),
            };
        }

        public override void SketchToScene(ISketch sketch)
        {
            var terrainsSketch = (IInteractionsSketch)sketch;
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

            foreach (var interactionSketch in sketches)
            {
                var interactionSketcher = ChileSketchToScene(interactionSketch);
            }
        }

        private Sketcher ChileSketchToScene(ISketch interactionSketch)
        {
            switch (interactionSketch)
            {
                case ICheckpointSketch checkpointSketch:
                    return CheckpointSketcher.Generate(checkpointSketch, transform);
                default:
                    throw new ArgumentOutOfRangeException(nameof(interactionSketch));
            }
        }

        #endregion
    }
}