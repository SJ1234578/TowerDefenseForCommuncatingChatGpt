using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void Initialize(GameObject UIManagerObject)
    {
        Debug.Log("UIManager Initialize");

        DontDestroyOnLoad(UIManagerObject);
    }

    public void ShowMessage(string message)
    {
        Debug.Log("Showing message: " + message);
    }
}