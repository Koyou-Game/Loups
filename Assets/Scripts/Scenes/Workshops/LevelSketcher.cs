using Entities;
using Koyou.Commons;
using Scenes.Games;
using UnityEngine;

namespace Scenes.Workshops
{
    public class LevelSketcher : MonoBehaviour
    {
        #region MapSerializer

        [SerializeField] private MapView mapView;

        #endregion

        public void Save(IWorkshop workshop)
        {
            Log.N($"Saving workshop {workshop}");
        }
    }
}