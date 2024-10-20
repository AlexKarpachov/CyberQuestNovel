using Naninovel;
using UnityEngine;
using RegularScripts;

namespace Naninovel.Commands
{
    [CommandAlias("activateMapButton")]
    public class ActivateMapButtonCommand : Command
    {
        public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
        {
            var uiManager = Object.FindObjectOfType<MainMenuController>();
            if (uiManager != null)
            {
                uiManager.ActivateMapButton(); 
            }
            return UniTask.CompletedTask;
        }
    }
}
