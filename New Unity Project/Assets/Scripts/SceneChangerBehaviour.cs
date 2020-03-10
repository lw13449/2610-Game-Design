using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerBehaviour : MonoBehaviour
{
    public void GoToNextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    //Need to figure out how to instansiate this without a UI button. 
}

