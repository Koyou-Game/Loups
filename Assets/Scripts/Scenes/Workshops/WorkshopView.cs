using Entities;
using Koyou.Commons;
using Koyou.Frameworks;
using UnityEngine;

namespace Scenes.Workshops
{
    public class WorkshopView : DataView<IWorkshop>
    {
        #region MonoBehaviour

        private void Start()
        {
            InitData();
        }

        #endregion

        #region WorkshopView

        [SerializeField] private LevelSketcher levelSketcher;
        [SerializeField] private WorkshopUiView workshopUiView;

        private void InitData()
        {
            workshopUiView.Callback = new WorkshopCallback(this);
        }

        private class WorkshopCallback : WorkshopUiView.ICallback
        {
            private readonly WorkshopView _owner;

            public WorkshopCallback(WorkshopView owner)
            {
                this._owner = owner;
            }

            public void OnPlayClick()
            {
                Log.N($"Called");
            }

            public void OnSaveClick()
            {
                _owner.levelSketcher.Save(_owner.Data);
            }
        }

        #endregion
    }
}