using Cysharp.Threading.Tasks;
using Koyou.Frameworks;

namespace Scenes.Splashes
{
    public class SplashState : AppState
    {
        #region AppState

        public override async UniTask Enter()
        {
            await base.Enter();
            
            await UniTask.Delay(1000);
            
            
        }

        public override async UniTask Exit()
        {
            await base.Exit();
        }

        #endregion
    }
}