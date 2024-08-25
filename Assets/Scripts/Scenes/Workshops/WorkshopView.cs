using Entities;
using Koyou.Commons;
using Koyou.Frameworks;
using Scenes.Games;
using Sketches.Entities;
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
                _owner = owner;
            }

            public void OnPlayClick()
            {
                Log.N($"Called");
                AppStateMachine.Instance.EnqueueState(new GameAppState());
            }

            public void OnSaveClick()
            {
                var sketch = _owner.levelSketcher.ToSketch();
                var json = JsonUtil.SerializeObject(sketch);
                var shapeSketch = JsonUtil.DeserializeObject<LevelSketch>(json);

                Log.N($"json:{json}");
            }
        }

        #endregion
    }
}