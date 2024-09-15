using Scenes.Workshops.Components;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Workshops
{
    public class OperatesUiView : MonoBehaviour
    {
        #region MonoBehaviour

        #endregion

        #region OperatesUiView

        [SerializeField]
        private ToggleGroup toggleGroup;

        public OperateItem SelectedOperateItem { get; set; }

        #endregion
    }
}