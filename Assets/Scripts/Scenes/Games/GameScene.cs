using Cysharp.Threading.Tasks;
using Entities;
using Koyou.Frameworks;
using Storages.Entities;
using UnityEngine;

namespace Scenes.Games
{
    public class GameScene : BaseScene
    {
        #region MonoBehaviour

        private void Start()
        {
#if UNITY_EDITOR
            if (Game == null)
            {
                // todo 之前 workshop保存的，这里用于测试
                Game = new Game
                {
                    LevelPath = new LevelPath(
                        "Workshop",
                        "TempPlayLevel",
                        "C:/Users/ayyk/AppData/LocalLow/DefaultCompany/Loups/Workshop/TempPlayLevel.json" // todo 之前 workshop保存的
                    )
                };
                RunSceneFlow();
            }
#endif
        }

        #endregion

        #region BaseScene

        public override async UniTask Enter()
        {
            await base.Enter();
            await gameView.LoadData(Game);
        }

        public override async UniTask Exit()
        {
            await gameView.UnloadData();
            await base.Exit();
        }

        #endregion

        #region GameScene

        [SerializeField] private GameView gameView;

        public IGame Game { get; set; }

        #endregion
    }
}