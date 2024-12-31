using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    public int CurrentStage;
    public int CurrentSubStage;

    public void Initialize(GameObject StageManagerObject)
    {
        Debug.Log("StageManager Initialize");

        DontDestroyOnLoad(StageManagerObject);

        CurrentStage = 1;
        CurrentSubStage = 1;
    }

    public void LoadStage(int stageNumber, int subStageNumber)
    {
        Debug.Log("Loading stage: " + stageNumber + " subStage: " + subStageNumber);

        CurrentStage = stageNumber;
        CurrentSubStage = subStageNumber;
    }

    public void LoadNextStage()
    {
        
    }
}