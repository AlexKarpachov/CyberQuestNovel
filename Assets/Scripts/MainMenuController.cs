using Naninovel;
using Naninovel.UI;
using UnityEngine;
using UnityEngine.UI;

namespace RegularScripts
{
    public class MainMenuController : MonoBehaviour
    {
        [SerializeField] GameObject variableInputUI;
        [SerializeField] Canvas mainMenuCanvas;
        [SerializeField] Button startButton;
        [SerializeField] VariableInputPanel variableInputPanel;
        [SerializeField] InputField nameInputField;
        [SerializeField] GameObject mapButtonCanvas;
        [SerializeField] GameObject secondMapButtonCanvas;
        [SerializeField] GameObject globalMapButton;

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
            globalMapButton.SetActive(true);

            customVariableManager.SetVariableValue("PlayerName", playerName);

            var scriptPlayer = Engine.GetService<IScriptPlayer>();
            await scriptPlayer.PreloadAndPlayAsync("Location1");
        }

        public async void OnSceneLoadedAction()
        {
            mainMenuCanvas.enabled = false;

            var scriptPlayer = Engine.GetService<IScriptPlayer>();
            await scriptPlayer.PreloadAndPlayAsync("Location2.1");
        }

        public void ActivateCanvas()
        {
            if (mapButtonCanvas != null)
            {
                mapButtonCanvas.SetActive(true);
            }
        }

        public void ActivateMapButton()
        {
            if (secondMapButtonCanvas != null)
            {
                secondMapButtonCanvas.SetActive(true);
            }
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
}
