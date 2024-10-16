using UnityEngine;
using UnityEngine.SceneManagement;

namespace DTT.MinigameMemory.Demo
{

    public class BetweenScenesScript : MonoBehaviour
    {
        public static BetweenScenesScript Instance;

        bool miniGameWasPlayed = false;

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
                return;
            }

            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        private void Update()
        {
            if (MemoryUIManager.miniGameWasPlayed)
            {
                miniGameWasPlayed = MemoryUIManager.miniGameWasPlayed;
            }
        }

         public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
         {
             if (scene.name == "MainMenu" && miniGameWasPlayed)
             {
                 MainMenuController scene2Controller = FindObjectOfType<MainMenuController>();
                 if (scene2Controller != null)
                 {
                     scene2Controller.OnSceneLoadedAction();
                 }
             }
         }

        public void OnDestroy()
        {
            SceneManager.sceneLoaded -= OnSceneLoaded;
        }
    }
}
