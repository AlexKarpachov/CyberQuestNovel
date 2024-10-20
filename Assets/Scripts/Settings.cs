using Naninovel;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public async void OnButtonClick()
    {
        var scriptPlayer = Engine.GetService<IScriptPlayer>();

        if (scriptPlayer != null)
        {
            await scriptPlayer.PreloadAndPlayAsync("MainScript");
        }
    }
}
