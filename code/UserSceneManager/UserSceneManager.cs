using UnityEngine;
using UnityEngine.SceneManagement;

// Change name to UserSceneManager, avoid conflict with SceneManager
public class UserSceneManager : MonoBehaviour
{
    public void Initialize(GameObject UserSceneManagerObject)
    {
        Debug.Log("UserSceneManager Initialize");

        DontDestroyOnLoad(UserSceneManagerObject);
    }

    public void LoadScene(string sceneName)
    {
        Debug.Log($"Loading scene: {sceneName}");
        SceneManager.LoadScene(sceneName);
    }
}
