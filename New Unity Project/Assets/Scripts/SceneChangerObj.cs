using UnityEngine.SceneManagement;
using UnityEngine;

[CreateAssetMenu]
public class SceneChange : ScriptableObject
{
    //private Object scene;
    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void GoToNextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    //public void OnTriggerEnter()
    //{
    //    LoadScene(scene);
    //}
}