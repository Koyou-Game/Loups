using System;
using Cysharp.Threading.Tasks;
using Entities;
using Koyou.Frameworks;
using Storages.Entities;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

namespace Scenes.Games
{
    public class GameAppState : AppState
    {
        #region AppState

        public override async UniTask Enter()
        {
            await base.Enter();

            await SceneManager.LoadSceneAsync("Game").ToUniTask();
            var scene = Object.FindFirstObjectByType<GameScene>() ?? throw new Exception($"{nameof(GameScene)} not found");
            
            scene.Game = new Game
            {
                LevelPath = _levelPath,
            };
            await scene.Enter();
        }

        public override async UniTask Exit()
        {
            await base.Exit();
        }

        #endregion

        #region GameAppState

        private readonly LevelPath _levelPath;

        public GameAppState() { }

        public GameAppState(LevelPath levelPath)
        {
            _levelPath = levelPath;
        }

        #endregion
    }
}