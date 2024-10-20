using Naninovel;
using UnityEngine;

public class Location11Loader : MonoBehaviour
{
    public async void OnButtonClick()
    {
        var scriptPlayer = Engine.GetService<IScriptPlayer>();

        if (scriptPlayer != null)
        {
            await scriptPlayer.PreloadAndPlayAsync("Location1.1");
        }
    }
}
