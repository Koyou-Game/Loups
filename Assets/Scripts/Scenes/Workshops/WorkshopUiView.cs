using Koyou.Commons;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Workshops
{
    public class WorkshopUiView : MonoBehaviour
    {
        #region WorkshopUiView

        [SerializeField] private Button saveBtn;

        public ICallback Callback { get; set; }

        private void Start()
        {
            saveBtn.onClick.AddListener(OnSaveBtnClick);
        }

        private void OnSaveBtnClick()
        {
            // Log.N($"OnSaveBtnClick");
            Callback?.OnSaveClick();
        }

        public interface ICallback
        {
            void OnSaveClick();
        }

        #endregion
    }
}