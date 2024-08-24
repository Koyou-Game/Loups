using Koyou.Commons;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Workshops
{
    public class WorkshopUiView : MonoBehaviour
    {
        #region WorkshopUiView

        [SerializeField] private Button playBtn;
        [SerializeField] private Button saveBtn;

        public ICallback Callback { get; set; }

        private void Start()
        {
            playBtn.onClick.AddListener(OnPlayBtnClick);
            saveBtn.onClick.AddListener(OnSaveBtnClick);
        }

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

        #endregion
    }
}