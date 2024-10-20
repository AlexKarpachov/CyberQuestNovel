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
        }
        
        return UniTask.CompletedTask;
    }
}
