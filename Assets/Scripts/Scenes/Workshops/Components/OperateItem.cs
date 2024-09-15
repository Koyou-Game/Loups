using Koyou.Indicators;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Workshops.Components
{
    public abstract class OperateItem : MonoBehaviour
    {
        #region MonoBehaviour

        protected virtual void Start()
        {
            if (toggle != null)
            {
                toggle.onValueChanged.AddListener(OnToggle);
                OnToggle(toggle.isOn);
            }
        }

        #endregion

        #region OperateItem

        [SerializeField] private Toggle toggle;

        /// <summary>
        /// 如果要用到 IndicatorManager 再实现这个
        /// </summary>
        public abstract IndicatorManager.IPointListener PointReceiver { get; protected set; }

        public virtual void OnToggle(bool isOn) { }

        #endregion
    }
}