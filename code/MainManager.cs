using UnityEngine;

// This code will be inspected by FirstScene > MainManager
public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public StageManager StageManager;
    public SoundManager SoundManager;
    public UIManager UIManager;
    public UserSceneManager UserSceneManager;

    private void Awake()
    {
        // Singleton pattern to prevent duplicate creation
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            InitializeManagers();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void InitializeManagers()
    {
        if (StageManager == null)
        {
            GameObject stageManagerObject = new GameObject("StageManager");
            StageManager = stageManagerObject.AddComponent<StageManager>();

            StageManager.Initialize(stageManagerObject);
        }

        if (SoundManager == null)
        {
            GameObject soundManagerObject = new GameObject("SoundManager");
            SoundManager = soundManagerObject.AddComponent<SoundManager>();

            SoundManager.Initialize(soundManagerObject);
        }

        if (UIManager == null)
        {
            GameObject UIManagerObject = new GameObject("UIManager");
            UIManager = UIManagerObject.AddComponent<UIManager>();

            UIManager.Initialize(UIManagerObject);
        }

        if (UserSceneManager == null)
        {
            GameObject userSceneManagerObject = new GameObject("UserSceneManager");
            UserSceneManager = userSceneManagerObject.AddComponent<UserSceneManager>();

            UserSceneManager.Initialize(userSceneManagerObject);
        }
    }
}