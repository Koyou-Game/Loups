using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Workshops.Components
{
    public class TerrainsPanel : MonoBehaviour
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