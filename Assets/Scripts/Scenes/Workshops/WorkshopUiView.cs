using Koyou.Commons;
using Koyou.Indicators;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Workshops
{
    public class WorkshopUiView : MonoBehaviour
    {
        #region MonoBehaviour

        private void Awake()
        {
            indicatorManager.pointListener = new PointListener(this);
        }

        private void Start()
        {
            playBtn.onClick.AddListener(OnPlayBtnClick);
            saveBtn.onClick.AddListener(OnSaveBtnClick);
        }

        #endregion

        #region WorkshopUiView

        [SerializeField]
        private IndicatorManager indicatorManager;

        [Space] [SerializeField]
        private OperatesUiView operatesUiView;

        [Space] [SerializeField]
        private Button playBtn;
        [SerializeField] private Button saveBtn;

        public ICallback Callback { get; set; }

        private void OnPlayBtnClick()
        {
            Callback?.OnPlayClick();
        }

        private void OnSaveBtnClick()
        {
            // Log.N($"OnSaveBtnClick");
            Callback?.OnSaveClick();
        }

        public interface ICallback
        {
            void OnPlayClick();
            void OnSaveClick();
        }

        private class PointListener : IndicatorManager.IPointListener
        {
            private WorkshopUiView _owner;

            public PointListener(WorkshopUiView owner)
            {
                _owner = owner;
            }

            #region IndicatorManager.IPointListener

            public void OnPointerDown(Vector2Int pos, Vector3 positionSnap)
            {
                // Log.N($"Called");
                _owner.operatesUiView.SelectedOperateItem?.PointReceiver?.OnPointerDown(pos, positionSnap);
            }

            public void OnPointerMove(Vector2Int pos, Vector3 positionSnap)
            {
                // Log.N($"Called");
                _owner.operatesUiView.SelectedOperateItem?.PointReceiver?.OnPointerMove(pos, positionSnap);
            }

            public void OnPointerUp(Vector2Int pos, Vector3 positionSnap)
            {
                // Log.N($"Called");
                _owner.operatesUiView.SelectedOperateItem?.PointReceiver?.OnPointerUp(pos, positionSnap);
            }

            #endregion
        }

        #endregion
    }
}