// This code will be inspected by FirstScene > Main Camera

using UnityEngine;

public class PersistentMainCamera : MonoBehaviour
{
    private static PersistentMainCamera instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        InitializeCamera();
    }

    private void InitializeCamera()
    {
        Debug.Log("Main Camera Initialized for new scene.");
    }
}