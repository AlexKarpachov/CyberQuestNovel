using Naninovel;
using Naninovel.UI;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] GameObject variableInputUI;
    [SerializeField] Button startButton;
    [SerializeField] VariableInputPanel variableInputPanel;
    [SerializeField] InputField nameInputField;

    private ICustomVariableManager customVariableManager;

    private void Start()
    {
        customVariableManager = Engine.GetService<ICustomVariableManager>();
    }
    public void OnStartButtonClicked()
    {
        variableInputUI.SetActive(true);
        startButton.gameObject.SetActive(false);
        variableInputPanel.Show("PlayerName", "Enter your name", string.Empty, false);
    }

    public async void OnSubmitButtonClicked()
    {
        string playerName = nameInputField.text;

        if (string.IsNullOrWhiteSpace(playerName))
        {
            Debug.LogWarning("This field cannot be empty");
            return;
        }

        customVariableManager.SetVariableValue("PlayerName", playerName);

        var scriptPlayer = Engine.GetService<IScriptPlayer>();
        await scriptPlayer.PreloadAndPlayAsync("Location1");
    }

    public void QuitGame()
    {
        // Для редактора
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // Для фінальної версії
        Application.Quit();
#endif
    }
}
