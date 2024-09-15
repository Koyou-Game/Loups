using Koyou.Indicators;
using UnityEngine;

namespace Scenes.Workshops.Components
{
    public abstract class OperateItem : MonoBehaviour
    {
        #region OperateItem

        /// <summary>
        /// 如果要用到 IndicatorManager 再实现这个
        /// </summary>
        public abstract IndicatorManager.IPointListener PointReceiver { get;protected set; }

        #endregion
    }
}