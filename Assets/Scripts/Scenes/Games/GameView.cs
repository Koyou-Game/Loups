using Cysharp.Threading.Tasks;
using Entities;
using Koyou.Frameworks;
using Koyou.Kogine.Side.Levels;
using Scenes.Workshops;
using Storages;
using UnityEngine;

namespace Scenes.Games
{
    public class GameView : DataView<IGame>
    {
        #region DataView<IGame>

        public override async UniTask LoadData(IGame data)
        {
            await base.LoadData(data);
            var (story, level, path) = data.LevelPath;
            var sketch = LevelRepository.Load(path);
            levelSketcher.SketchToScene(sketch);
            await levelController.Load();
        }

        public override async UniTask UnloadData()
        {
            await base.UnloadData();
        }

        #endregion

        #region GameView

        [SerializeField] private LevelSketcher levelSketcher;
        [SerializeField] private LevelController levelController;

        #endregion
    }
}