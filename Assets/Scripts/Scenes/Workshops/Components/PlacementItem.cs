using Koyou.Commons;
using Koyou.Indicators;
using Sketches;
using UnityEngine;

namespace Scenes.Workshops.Components
{
    /// <summary>
    /// Workshop场景中插入Placement的共通按钮
    /// </summary>
    public class PlacementItem : MonoBehaviour
    {
        #region MonoBehaviour

        private void Start()
        {
            PointReceiver = new PointListener(this);
        }

        #endregion

        #region PlacementItem

        [SerializeField] private Sketcher sketcher;

        /// <summary>
        /// 如果要用到 IndicatorManager 再实现这个
        /// </summary>
        public IndicatorManager.IPointListener PointReceiver { get; private set; }

        private class PointListener : IndicatorManager.IPointListener
        {
            private PlacementItem _owner;

            public PointListener(PlacementItem owner)
            {
                _owner = owner;
            }

            #region IndicatorManager.IPointListener

            public void OnPointerDown(Vector2Int pos, Vector3 positionSnap)
            {
                Log.N($"Called");
            }

            public void OnPointerMove(Vector2Int pos, Vector3 positionSnap)
            {
                Log.N($"Called");
            }

            public void OnPointerUp(Vector2Int pos, Vector3 positionSnap)
            {
                Log.N($"Called");
            }

            #endregion
        }

        #endregion
    }
}