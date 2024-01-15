using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleChanger : MonoBehaviour
{
    public void OnStart()
    {
        SceneManager.LoadScene("Main");
    }

    public void OnHowToPlay()
    {
        this.transform.localPosition = new Vector2(-2000, 0);
    }

    public void OnCredit()
    {
        this.transform.localPosition = new Vector2(0, 1200);
    }

    public void OnBackHowToPlay()
    {
        this.transform.localPosition = new Vector2(0, 0);
    }

    public void OnBackCredit()
    {
        this.transform.localPosition = new Vector2(0, 0);
    }
}
