using System;
using Cysharp.Threading.Tasks;
using Koyou.Frameworks;
using Object = UnityEngine.Object;

namespace Scenes.Splashes
{
    public class SplashState : AppState
    {
        #region AppState

        public override async UniTask Enter()
        {
            await base.Enter();

            await UniTask.Delay(1000);
            var splashScene = Object.FindFirstObjectByType<SplashScene>() ?? throw new Exception("SplashScene not found");
            await splashScene.Enter();
        }

        public override async UniTask Exit()
        {
            await base.Exit();
        }

        #endregion
    }
}