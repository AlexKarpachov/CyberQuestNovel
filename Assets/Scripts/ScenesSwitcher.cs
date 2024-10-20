using Naninovel;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesSwitcher : MonoBehaviour
{
    [SerializeField] GameObject mapCanvas;
    [SerializeField] GameObject romulusMapButton;
    [SerializeField] GameObject edgecityMapButton;
    [SerializeField] GameObject romulusToEdgecity;
    [SerializeField] GameObject edgecityToCityport;
    [SerializeField] GameObject edgecityToRomulus;
    [SerializeField] GameObject sphereScenario;
    [SerializeField] GameObject mapButton;

    public void RomulusToEdgecity()
    {
        mapCanvas.SetActive(true);
        romulusToEdgecity.SetActive(true);
        romulusMapButton.SetActive(false);
        edgecityToRomulus.SetActive(false);
        edgecityToCityport.SetActive(false);
        mapButton.SetActive(false);
    }

    public void EdgecityToCityport()
    {
        mapCanvas.SetActive(true);
        edgecityMapButton.SetActive(false);
        edgecityToCityport.SetActive(true);
        romulusToEdgecity.SetActive(false);
        edgecityToRomulus.SetActive(false);
        mapButton.SetActive(false);
    }

    public async void CityportToEdgecity()
    {
        sphereScenario.SetActive(false);
        mapButton.SetActive(false);

        var scriptPlayer = Engine.GetService<IScriptPlayer>();

        if (scriptPlayer != null)
        {
            await scriptPlayer.PreloadAndPlayAsync("Location2.2");
        }
    }

    public void EdgecityToRomulus()
    {
        mapCanvas.SetActive(true);
        edgecityToRomulus.SetActive(true);
        edgecityToCityport.SetActive(false);
        romulusToEdgecity.SetActive(false);
        mapButton.SetActive(false);
    }

}
