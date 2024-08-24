using Entities;
using Koyou.Commons;
using Sketches;
using Sketches.Entities;
using UnityEngine;

namespace Scenes.Workshops
{
    public class LevelSketcher : MonoBehaviour
    {
        #region MapSerializer

        [SerializeField] private MapSketcher mapSketcher;

        /// <summary>
        /// todo test
        /// </summary>
        public ShapeSketcher shapeSketcher;

        #endregion

        public void Save(IWorkshop workshop)
        {
            Log.N($"Saving workshop {workshop}");

            var sketch = shapeSketcher.ToSketch();
            // Unity 自带的 JsonUtility 不好用
            // var json = JsonUtility.ToJson(sketch);
            var json = JsonUtil.SerializeObject(sketch);
            var shapeSketch = JsonUtil.DeserializeObject<ShapeSketch>(json);
            Log.N($"json:{json}");
        }
    }
}