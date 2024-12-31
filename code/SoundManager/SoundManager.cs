using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public void Initialize(GameObject SoundManagerObject)
    {
        Debug.Log("SoundManager Initialize");

        DontDestroyOnLoad(SoundManagerObject);
    }

    public void PlaySound(string soundName)
    {
        Debug.Log("Playing sound: " + soundName);
    }
}