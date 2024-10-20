using Naninovel;
using UnityEngine;

public class Location2Loader : MonoBehaviour
{
    public async void OnButtonClick()
    {
        var scriptPlayer = Engine.GetService<IScriptPlayer>();

        if (scriptPlayer != null)
        {
            await scriptPlayer.PreloadAndPlayAsync("Location2");
        }
    }
}
