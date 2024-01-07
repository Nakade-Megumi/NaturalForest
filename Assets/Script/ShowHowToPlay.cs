using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowHowToPlay : MonoBehaviour
{
    public void LoadingNewScene()
    {
        SceneManager.LoadScene("HowToPlay");
    }
}
