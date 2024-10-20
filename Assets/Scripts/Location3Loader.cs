using Naninovel;
using UnityEngine;

public class Location3Loader : MonoBehaviour
{
    [SerializeField] GameObject sphereObjects;

    public void CityportStarter()
    {
        Invoke("SphereAnimation", 0.5f);
    }

    void SphereAnimation()
    {
        sphereObjects.SetActive(true);
        Invoke("OnButtonClick", 2f);
    }

    public async void OnButtonClick()
    {
        var scriptPlayer = Engine.GetService<IScriptPlayer>();

        if (scriptPlayer != null)
        {
            await scriptPlayer.PreloadAndPlayAsync("Location3");
        }
    }
}
