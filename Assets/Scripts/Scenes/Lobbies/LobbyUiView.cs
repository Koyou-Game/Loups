using Koyou.Frameworks;
using Scenes.Games;
using UnityEngine;

namespace Scenes.Lobbies
{
    public class LobbyUiView : MonoBehaviour
    {
        public void TapStart()
        {
            AppStateMachine.Instance.EnqueueState(new GameAppState());
        }
    }
}