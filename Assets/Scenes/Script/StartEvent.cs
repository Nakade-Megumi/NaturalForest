using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartEvent : MonoBehaviour
{
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

        if (judge%2 == 0)
        {
            Debug.Log("Success!");
        }
        else
        {
            Debug.Log("Failed...");
        }
        //eventCard.SetActive(false);
    }
}
