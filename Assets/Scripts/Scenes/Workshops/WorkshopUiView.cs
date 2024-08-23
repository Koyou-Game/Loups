using Koyou.Commons;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Workshops
{
    public class WorkshopUiView : MonoBehaviour
    {
        #region WorkshopUiView

        [SerializeField] private Button saveBtn;

        private void Start()
        {
            saveBtn.onClick.AddListener(OnSaveBtnClick);
        }

        private void OnSaveBtnClick()
        {
            Log.N($"OnSaveBtnClick");
        }

        #endregion
    }
}