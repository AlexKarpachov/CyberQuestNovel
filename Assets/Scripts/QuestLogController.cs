using Naninovel;
using TMPro;
using UnityEngine;

public class QuestLogController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI taskText1;
    [SerializeField] TextMeshProUGUI taskText1_1;
    [SerializeField] TextMeshProUGUI taskText1_2;
    [SerializeField] TextMeshProUGUI taskText2;
    [SerializeField] TextMeshProUGUI taskText3;
    [SerializeField] TextMeshProUGUI taskText3_1;
    [SerializeField] TextMeshProUGUI taskText4;

    private IScriptPlayer scriptPlayer;

    private void Start()
    {
        scriptPlayer = Engine.GetService<IScriptPlayer>();

        UpdateQuestLog();
    }

    private void Update()
    {
        UpdateQuestLog();
    }

    private void UpdateQuestLog()
    {
        string currentScript = scriptPlayer?.PlayedScript?.Name ?? string.Empty;

        switch (currentScript)
        {
            case "Location1":
                taskText1.text = "Find the way to Cityport";
                taskText1_1.text = "Find George who can show the way to Cityport";
                taskText1_1.gameObject.SetActive(true);

                taskText1.fontStyle = FontStyles.Normal;
                taskText1_1.fontStyle = FontStyles.Normal;
                break;

            case "Location2":
                taskText2.text = "Play the mini-game";
                taskText2.gameObject.SetActive(true);

                // taskText1.fontStyle = FontStyles.Strikethrough;
                taskText1_1.fontStyle = FontStyles.Strikethrough;
                taskText2.fontStyle = FontStyles.Normal;
                break;

            case "Location2.1":
                taskText1.text = "Find the way to Cityport";
                taskText1_1.text = "Find George who can show the way to Cityport";
                taskText1_2.text = "Find the energy sphere";
                taskText2.text = "Play the mini-game";
                taskText1_2.gameObject.SetActive(true);

                taskText1.fontStyle = FontStyles.Strikethrough;
                taskText1_1.fontStyle = FontStyles.Strikethrough;
                taskText2.fontStyle = FontStyles.Strikethrough;
                taskText1_2.fontStyle = FontStyles.Normal;
                break;

            case "Location3":
                taskText3.text = "Deliver the energy sphere to George in Edgecity";
                taskText3.gameObject.SetActive(true);

                taskText1_2.fontStyle = FontStyles.Strikethrough;
                taskText3.fontStyle = FontStyles.Normal;
                break;

            case "Location2.2":
                taskText3_1.text = "Try to find George in Romulus";
                taskText3_1.gameObject.SetActive(true);

                taskText3.fontStyle = FontStyles.Strikethrough;
                taskText3_1.fontStyle = FontStyles.Normal;
                break;

            case "Location1.1":
                taskText4.text = "Decide who to give the sphere to";
                taskText4.gameObject.SetActive(true);

                taskText3_1.fontStyle = FontStyles.Strikethrough;
                taskText4.fontStyle = FontStyles.Normal;
                break;

            default:
                break;
        }
    }
}