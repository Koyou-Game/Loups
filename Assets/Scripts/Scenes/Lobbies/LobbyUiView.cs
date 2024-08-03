using Koyou.Frameworks;
using Scenes.Games;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Lobbies
{
    public class LobbyUiView : MonoBehaviour
    {
        #region MonoBehaviour

        private void Awake()
        {
            startBtn.onClick.AddListener(TapStart);
        }

        #endregion

        #region LobbyUiView

        [SerializeField] private Button startBtn;

        private void TapStart()
        {
            AppStateMachine.Instance.EnqueueState(new GameAppState());
        }

        #endregion
    }
}