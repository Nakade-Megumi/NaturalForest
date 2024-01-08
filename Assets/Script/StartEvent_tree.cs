using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartEvent_tree : MonoBehaviour
{
    public Text logText;
    //[SerializeField] private GameObject eventCard;

    public void SearchEvent(int click)
    {
        switch (click)
        {
            case 1:
                EventTree();
                break;
            default: 
                break;
        }
    }

    public void EventTree()
    {        
        int judge = Random.Range(0, 10);
        Debug.Log(judge);

        string message;

        if (judge % 2 == 0)
        {
            if (judge == 0)
            {
                message = "Success!_apple";
            }
            else if (judge == 2)
            {
                message = "Success!_orange";
            }
            else if (judge == 4)
            {
                message = "Success!_cherry";
            }
            else if (judge == 6)
            {
                message = "Success!_peach";
            }
            else
            {
                message = "Success!_honey";
            }
        }
        else
        {
            if (judge == 1 || judge == 3)
            {
                message = "Failed..._leaf";
            }
            else
            {
                message = "Failed..._bee";
            }
        }

        Debug.Log(message);
        DisplayLog(message);
        //eventCard.SetActive(false);
    }

    void DisplayLog(string message)
    {
        logText.text = message;
    }
}
