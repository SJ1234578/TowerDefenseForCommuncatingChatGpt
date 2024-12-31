using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public void OnStageButtonClickedWrapper_Stage1_1()
    {
        OnStageButtonClicked(1, 1);
    }

    public void OnStageButtonClickedWrapper_Stage1_2()
    {
        OnStageButtonClicked(1, 2);
    }

    public void OnStageButtonClicked(int stageNumber, int subStageNumber)
    {
        if (MainManager.Instance != null)
        { 
            MainManager.Instance.StageManager.LoadStage(stageNumber, subStageNumber);
            MainManager.Instance.UserSceneManager.LoadScene("GameScene");
        }
        else
        {
            Debug.LogWarning("Call ButtonClick before MainManager Initialize");
        }
    }
}