using Naninovel;
using UnityEngine;
using UnityEngine.UI;

public class MapButtonController : MonoBehaviour
{
    [SerializeField] Button mapButton;
    [SerializeField] Sprite mapIcon;
    [SerializeField] Sprite closeIcon;
    [SerializeField] GameObject mapCanvas;
    [SerializeField] RectTransform YouAreHereText;
    [SerializeField] GameObject romulusToEdgecity;
    [SerializeField] GameObject edgecityToCityport;
    [SerializeField] GameObject edgecityToRomulus;
    [SerializeField] GameObject rewardUIObjcet;

    private bool isMapOpen = false;
    private IScriptPlayer scriptPlayer;

    private void Start()
    {
        scriptPlayer = Engine.GetService<IScriptPlayer>();

        mapButton.image.sprite = mapIcon;
        mapCanvas.SetActive(false);
        YouAreHereText.gameObject.SetActive(false);
    }

    public void ToggleMap()
    {
        isMapOpen = !isMapOpen;

        if (isMapOpen)
        {
            mapCanvas.SetActive(true);
            romulusToEdgecity.SetActive(false);
            edgecityToCityport.SetActive(false);
            edgecityToRomulus.SetActive(false);
            rewardUIObjcet.SetActive(false);
            mapButton.image.sprite = closeIcon;

            UpdateTextElementPosition();
        }
        else
        {
            rewardUIObjcet.SetActive(true);
            mapCanvas.SetActive(false);
            mapButton.image.sprite = mapIcon;
            YouAreHereText.gameObject.SetActive(false);
        }
    }

    private void UpdateTextElementPosition()
    {
        if (scriptPlayer == null || scriptPlayer.PlayedScript == null) return;

        string currentScriptName = scriptPlayer.PlayedScript.Name;
        Vector2 newAnchoredPosition = YouAreHereText.anchoredPosition;

        switch (currentScriptName)
        {
            case "Location1":
            case "Location1.1":
                newAnchoredPosition = new Vector2(755f, -490f);
                break;

            case "Location2":
            case "Location2.1":
            case "Location2.2":
                newAnchoredPosition = new Vector2(1175f, -457f);
                break;

            case "Location3":
                newAnchoredPosition = new Vector2(1360f, -600f);
                break;
        }

        YouAreHereText.anchoredPosition = newAnchoredPosition;
        YouAreHereText.gameObject.SetActive(true);
    }
}
