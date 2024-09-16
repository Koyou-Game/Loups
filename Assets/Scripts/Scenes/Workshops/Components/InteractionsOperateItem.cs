using Koyou.Indicators;
using UnityEngine;

namespace Scenes.Workshops.Components
{
    public class InteractionsOperateItem : OperateItem
    {
        #region MonoBehaviour

        protected override void Start()
        {
            base.Start();
            PointReceiver = new PointListener(this);
        }

        #endregion

        #region OperateItem

        public override IndicatorManager.IPointListener PointReceiver { get; protected set; }

        public override void OnToggle(bool isOn)
        {
            base.OnToggle(isOn);
            interactionsPanel.gameObject.SetActive(isOn);
        }

        #endregion

        #region TerrainsOperateItem

        [Space] [SerializeField]
        private InteractionsPanel interactionsPanel;

        private class PointListener : IndicatorManager.IPointListener
        {
            private readonly InteractionsOperateItem _owner;

            public PointListener(InteractionsOperateItem owner)
            {
                _owner = owner;
            }

            #region IndicatorManager.IPointListener

            public void OnPointerDown(Vector2Int pos, Vector3 positionSnap)
            {
                // Log.N($"Called");
                var placementItem = _owner.interactionsPanel.SelectedItem;
                if (placementItem != null)
                {
                    placementItem.PointReceiver?.OnPointerDown(pos, positionSnap);
                }
            }

            public void OnPointerMove(Vector2Int pos, Vector3 positionSnap)
            {
                // Log.N($"Called");
                var placementItem = _owner.interactionsPanel.SelectedItem;
                if (placementItem != null)
                {
                    placementItem.PointReceiver?.OnPointerMove(pos, positionSnap);
                }
            }

            public void OnPointerUp(Vector2Int pos, Vector3 positionSnap)
            {
                // Log.N($"Called");
                var placementItem = _owner.interactionsPanel.SelectedItem;
                if (placementItem != null)
                {
                    placementItem.PointReceiver?.OnPointerUp(pos, positionSnap);
                }
            }

            #endregion
        }

        #endregion
    }
}