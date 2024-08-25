using Sketches;
using Sketches.Entities;
using UnityEngine;

namespace Scenes.Workshops
{
    public class LevelSketcher : Sketcher
    {
        #region Sketcher

        public override ISketch ToSketch()
        {
            return new LevelSketch
            {
                MapSketch = (IMapSketch)mapSketcher.ToSketch(),
            };
        }

        #endregion

        #region MapSerializer

        [SerializeField] private MapSketcher mapSketcher;

        #endregion
    }
}