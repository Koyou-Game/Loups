using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Workshops.Components
{
    /// <summary>
    /// 暂时和 TerrainsPanel 没有区别，后期看是否合并
    /// </summary>
    public class InteractionsPanel : MonoBehaviour
    {
        #region MonoBehaviour

        private void Start()
        {
            foreach (var toggle in toggleGroup.ActiveToggles())
            {
                if (!toggle.isOn) continue;
                var placementItem = toggle.GetComponent<PlacementItem>();
                if (placementItem == null) continue;
                toggle.onValueChanged.AddListener(isOn =>
                {
                    if (isOn)
                    {
                        SelectedItem = placementItem;
                    }
                });
                break;
            }
            // 遍历 ActiveToggles 找到被选中的 Toggle
            foreach (var toggle in toggleGroup.ActiveToggles())
            {
                if (!toggle.isOn) continue;
                var placementItem = toggle.GetComponent<PlacementItem>();
                if (placementItem == null) continue;
                SelectedItem = placementItem;
                break;
            }
        }

        #endregion

        #region TerrainsPanel

        [SerializeField]
        private ToggleGroup toggleGroup;

        // private readonly List<PlacementItem> _placementItems = new();

        public PlacementItem SelectedItem { get; private set; }

        #endregion
    }
}