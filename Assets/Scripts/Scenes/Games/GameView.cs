using Cysharp.Threading.Tasks;
using Entities;
using Koyou.Frameworks;
using Koyou.Kogine.Side.Cores;
using UnityEngine;

namespace Scenes.Games
{
    public class GameView : DataView<Game>
    {
        #region DataView<Game>

        public override async UniTask LoadData(Game data)
        {
            await base.LoadData(data);
            await levelController.Load();
        }

        public override async UniTask UnloadData()
        {
            await base.UnloadData();
        }

        #endregion

        #region GameView

        [SerializeField] private LevelController levelController;

        #endregion
    }
}