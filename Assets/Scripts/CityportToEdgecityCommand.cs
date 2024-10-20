using Naninovel;
using UnityEngine;

[CommandAlias("cityportToEdgecity")]
public class CityportToEdgecityCommand : Command
{
    public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        var scenesSwitcher = Object.FindObjectOfType<ScenesSwitcher>();
        if (scenesSwitcher != null)
        {
            scenesSwitcher.CityportToEdgecity();
        }

        return UniTask.CompletedTask;
    }
}
