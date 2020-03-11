using UnityEngine.SceneManagement;
using UnityEngine;

[CreateAssetMenu]
public class SceneChange : ScriptableObject
{
    private Object scene;
    public void LoadScene(Object sceneName)
    {
        var newName = sceneName.name;
        SceneManager.LoadScene(newName);
    }
    public void GoToNextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OnTriggerEnter()
    {
        LoadScene(scene);
    }
}