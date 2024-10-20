using Naninovel;
using UnityEngine;

namespace Naninovel.Commands
{
    [CommandAlias("EdgecityToRomulus")]
    public class EdgecityToRomulusCommand : Command
    {
        public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
        {
            var sceneSwitcher = Object.FindObjectOfType<ScenesSwitcher>();
            if (sceneSwitcher != null)
            {
                sceneSwitcher.EdgecityToRomulus();
            }

            return UniTask.CompletedTask;
        }
    }
}
