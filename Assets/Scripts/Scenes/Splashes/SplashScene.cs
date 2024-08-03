using Cysharp.Threading.Tasks;
using Koyou.Commons;
using Koyou.Frameworks;
using Scenes.Lobbies;

namespace Scenes.Splashes
{
    public class SplashScene : BaseScene
    {
        #region BaseScene

        public override async UniTask Enter()
        {
            await base.Enter();
            Log.N($"Entered {nameof(SplashScene)}");
            // todo splash operates
            AppStateMachine.Instance.EnqueueState(new LobbyAppState());
        }

        public override async UniTask Exit()
        {
            await base.Exit();
        }

        #endregion
    }
}