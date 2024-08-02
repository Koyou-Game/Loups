using Cysharp.Threading.Tasks;
using Entities;
using Koyou.Frameworks;

namespace Scenes.Lobbies
{
    public class LobbyView : DataView<Lobby>
    {
        #region DataView<Lobby>

        public override async UniTask LoadData(Lobby data)
        {
            await base.LoadData(data);
        }

        public override async UniTask UnloadData()
        {
            await base.UnloadData();
        }

        #endregion
    }
}