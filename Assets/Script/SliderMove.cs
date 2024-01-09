using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SliderMove : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] float succses_min;
    [SerializeField] float succses_max;
    private bool isClicked;
    private bool maxValue;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = 0;
        maxValue = false;
        isClicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isClicked == false)
        {
            Debug.Log("stop");
            isClicked = true;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && isClicked == true)
        {
            Debug.Log("start");
            isClicked = false;
        }
        if (isClicked)
        {
            if (slider.value >= succses_min && slider.value <= succses_max)
            {
                //該当する画像を出したい
                Debug.Log("Success!");
                SceneManager.LoadScene("Main");

            }
            else
            {
                //該当する画像を出したい
                Debug.Log("Failed...");
                SceneManager.LoadScene("Main");
            }
            return;
        }

        if (slider.value == 10)
        {
            maxValue = true;
        }
        if (slider.value == 0)
        {
            maxValue = false;
        }

        if (maxValue == true)
        {
            slider.value -= 0.1f;
        }

        if (maxValue == false)
        {
            slider.value += 0.1f;
        }
    }
}