using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleChanger : MonoBehaviour
{
    public void SetSound()
    {
        SoundDecision soundDecision = SoundDecision.Instance;
        soundDecision.OnDecision();
    }

    public void OnStart()
    {
        SetSound();
        SceneManager.LoadScene("Main");
    }

    public void OnHowToPlay()
    {
        SetSound();
        this.transform.localPosition = new Vector2(-2000, 0);
    }

    public void OnCredit()
    {
        SetSound();
        this.transform.localPosition = new Vector2(0, 1200);
    }

    public void OnBackHowToPlay()
    {
        SetSound();
        this.transform.localPosition = new Vector2(0, 0);
    }

    public void OnBackCredit()
    {
        SetSound();
        this.transform.localPosition = new Vector2(0, 0);
    }
}
