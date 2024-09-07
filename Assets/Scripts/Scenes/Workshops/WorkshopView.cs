using Entities;
using Koyou.Commons;
using Koyou.Frameworks;
using Scenes.Games;
using Sketches.Entities;
using Storages;
using Storages.Entities;
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
                var sketch = (ILevelSketch)_owner.levelSketcher.SceneToSketch();
                var json = JsonUtil.SerializeObject(sketch);

                Log.N($"json:{json}");

#if UNITY_EDITOR
                // test
                var levelSketch = JsonUtil.DeserializeObject<LevelSketch>(json);
#endif

                var story = "Workshop";
                var level = "TempPlayLevel";
                var path = LevelRepository.Save(sketch, story, level);

                var levelPath = new LevelPath(
                    story,
                    level,
                    path
                );
                AppStateMachine.Instance.EnqueueState(new GameAppState(levelPath));
            }

            public void OnSaveClick()
            {
                var sketch = (ILevelSketch)_owner.levelSketcher.SceneToSketch();
                var json = JsonUtil.SerializeObject(sketch);

                Log.N($"json:{json}");

#if UNITY_EDITOR
                // test
                var levelSketch = JsonUtil.DeserializeObject<LevelSketch>(json);
#endif

                LevelRepository.Save(sketch, "Workshop", "TempLevel");
            }
        }

        #endregion
    }
}