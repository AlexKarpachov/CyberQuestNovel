using Naninovel;
using UnityEngine;
using RegularScripts;

namespace Naninovel.Commands
{
    [CommandAlias("activateCanvas")]
    public class ActivateCanvasCommand : Command
    {
        public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
        {
            var uiManager = Object.FindObjectOfType<MainMenuController>();
            if (uiManager != null)
            {
                uiManager.ActivateCanvas();
            }
            return UniTask.CompletedTask;
        }
    }
}
