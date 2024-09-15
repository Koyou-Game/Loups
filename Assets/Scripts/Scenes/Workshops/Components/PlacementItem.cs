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
        [SerializeField] private Sketcher sketcher;

        /// <summary>
        /// 如果要用到 IndicatorManager 再实现这个
        /// </summary>
        public IndicatorManager.IPointListener PointReceiver { get; protected set; }
    }
}