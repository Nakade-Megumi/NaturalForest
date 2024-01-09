using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderMove : MonoBehaviour
{
    [SerializeField] Slider slider;
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
            if (slider.value >= 3.92 && slider.value <= 5.96)
            {
                Debug.Log("Success!");
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