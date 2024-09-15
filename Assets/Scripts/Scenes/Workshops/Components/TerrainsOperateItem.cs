using Koyou.Commons;
using Koyou.Indicators;
using UnityEngine;

namespace Scenes.Workshops.Components
{
    public class TerrainsOperateItem : OperateItem
    {
        #region MonoBehaviour

        private void Start()
        {
            PointReceiver = new PointListener(this);
        }

        #endregion

        #region OperateItem

        public override IndicatorManager.IPointListener PointReceiver { get; protected set; }

        #endregion

        #region TerrainsOperateItem

        [SerializeField]
        private TerrainsPanel terrainsPanel;

        private class PointListener : IndicatorManager.IPointListener
        {
            private readonly TerrainsOperateItem _owner;

            public PointListener(TerrainsOperateItem owner)
            {
                _owner = owner;
            }

            #region IndicatorManager.IPointListener

            public void OnPointerDown(Vector2Int pos, Vector3 positionSnap)
            {
                Log.N($"Called");
                var placementItem = _owner.terrainsPanel.SelectedItem;
                if (placementItem != null)
                {
                    placementItem.PointReceiver?.OnPointerDown(pos, positionSnap);
                }
            }

            public void OnPointerMove(Vector2Int pos, Vector3 positionSnap)
            {
                Log.N($"Called");
                var placementItem = _owner.terrainsPanel.SelectedItem;
                if (placementItem != null)
                {
                    placementItem.PointReceiver?.OnPointerMove(pos, positionSnap);
                }
            }

            public void OnPointerUp(Vector2Int pos, Vector3 positionSnap)
            {
                Log.N($"Called");
                var placementItem = _owner.terrainsPanel.SelectedItem;
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