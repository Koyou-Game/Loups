using Sketches;
using Sketches.Entities;
using UnityEngine;

namespace Scenes.Workshops
{
    public class LevelSketcher : Sketcher
    {
        #region Sketcher

        public override ISketch SceneToSketch()
        {
            return new LevelSketch
            {
                MapSketch = (IMapSketch)mapSketcher.SceneToSketch(),
            };
        }

        #endregion

        #region MapSerializer

        [SerializeField] private MapSketcher mapSketcher;

        #endregion
    }
}