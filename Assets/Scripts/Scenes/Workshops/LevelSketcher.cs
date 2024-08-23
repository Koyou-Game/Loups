using Entities;
using Koyou.Commons;
using Scenes.Games;
using Sketches;
using UnityEngine;

namespace Scenes.Workshops
{
    public class LevelSketcher : MonoBehaviour
    {
        #region MapSerializer

        [SerializeField] private MapView mapView;

        /// <summary>
        /// todo test
        /// </summary>
        public ShapeSketcher shapeSketcher;

        #endregion

        public void Save(IWorkshop workshop)
        {
            Log.N($"Saving workshop {workshop}");

            var sketch = shapeSketcher.ToSketch();
        }
    }
}