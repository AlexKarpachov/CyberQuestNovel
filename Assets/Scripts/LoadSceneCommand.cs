using Naninovel;
using UnityEngine;
using UnityEngine.SceneManagement;

[CommandAlias("loadScene")]
public class LoadSceneCommand : Command
{
    [ParameterAlias(NamelessParameterAlias), RequiredParameter]
    public StringParameter SceneName;

    public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        if (SceneName.HasValue)
        {
            SceneManager.LoadScene(SceneName);
            Debug.Log($"Loading scene: {SceneName}");
        }
        else
        {
            Debug.LogError("Scene name is not provided.");
        }

        return UniTask.CompletedTask;
    }
}
