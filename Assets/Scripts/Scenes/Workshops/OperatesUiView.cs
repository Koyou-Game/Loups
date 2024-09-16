using Scenes.Workshops.Components;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Workshops
{
    public class OperatesUiView : MonoBehaviour
    {
        #region MonoBehaviour

        private void Start()
        {
            foreach (var toggle in toggleGroup.ActiveToggles())
            {
                if (!toggle.isOn) continue;
                var placementItem = toggle.GetComponent<OperateItem>();
                if (placementItem == null) continue;
                toggle.onValueChanged.AddListener(isOn =>
                {
                    if (isOn)
                    {
                        SelectedOperateItem = placementItem;
                    }
                });
                break;
            }
            // 遍历 ActiveToggles 找到被选中的 Toggle
            foreach (var toggle in toggleGroup.ActiveToggles())
            {
                if (!toggle.isOn) continue;
                var placementItem = toggle.GetComponent<OperateItem>();
                if (placementItem == null) continue;
                SelectedOperateItem = placementItem;
                SelectedOperateItem.OnToggle(true);
                break;
            }
        }

        #endregion

        #region OperatesUiView

        [SerializeField]
        private ToggleGroup toggleGroup;

        public OperateItem SelectedOperateItem { get; private set; }

        #endregion
    }
}