using System;
using Cysharp.Threading.Tasks;
using Koyou.Frameworks;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

namespace Scenes.Lobbies
{
    public class LobbyAppState : AppState
    {
        #region AppState

        public override async UniTask Enter()
        {
            await base.Enter();

            await SceneManager.LoadSceneAsync("Lobby");

            var scene = Object.FindFirstObjectByType<LobbyScene>() ?? throw new Exception($"{nameof(LobbyScene)} not found");
            await scene.Enter();
        }

        public override async UniTask Exit()
        {
            await base.Exit();
        }

        #endregion
    }
}