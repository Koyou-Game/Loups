using Cysharp.Threading.Tasks;
using Entities;
using Koyou.Frameworks;
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
                Game = new Game
                {
                    // LevelPath = _levelPath,
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