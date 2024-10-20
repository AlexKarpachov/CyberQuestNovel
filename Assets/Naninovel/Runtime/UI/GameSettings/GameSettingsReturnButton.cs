// Copyright 2022 ReWaffle LLC. All rights reserved.

using UnityEngine;

namespace Naninovel.UI
{
    public class GameSettingsReturnButton : ScriptableButton
    {
        private GameSettingsMenu settingsMenu;
        private IStateManager settingsManager;
        GameObject mainMenuCanvas;

        protected override void Awake ()
        {
            base.Awake();

            settingsMenu = GetComponentInParent<GameSettingsMenu>();
            settingsManager = Engine.GetService<IStateManager>();
            mainMenuCanvas = GameObject.FindGameObjectWithTag("MainCanvas");
        }

        protected override void OnButtonClick () => ApplySettingsAsync().Forget();

        private async UniTaskVoid ApplySettingsAsync ()
        {
            using (var _ = new InteractionBlocker())
                await settingsManager.SaveSettingsAsync();
            settingsMenu.Hide();
            mainMenuCanvas.SetActive(true);
        }
    }
}
