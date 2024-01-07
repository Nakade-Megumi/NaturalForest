using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartEvent : MonoBehaviour
{
    public void SearchEvent(int click)
    {
        //InitGame initGame;
        //GameObject obj = GameObject.Find("EventSystem");
        switch (click)
        {
            case 0:
                EventFlower();
                break;
            case 1:
                EventTree();
                break;
            case 2:
                EventRiver();
                break;
            case 3:
                EventSea();
                break;
            default: 
                break;
        }
    }

    public void EventFlower()
    {

    }

    public void EventTree()
    {
        InitGame initGame;
        GameObject obj = GameObject.Find("EventSystem");
        initGame = obj.GetComponent<InitGame>();

        initGame.img.texture = initGame.texture_list_tree[0];
        Invoke("JudgeFruitEvent",2);
    }
    
    public void EventRiver()
    {

    }

    public void EventSea()
    {

    }

    public void JudgeFruitEvent() {
        InitGame initGame;
        GameObject obj = GameObject.Find("EventSystem");
        int judge = Random.Range(0, 10);
        int card_num = Random.Range(1,4);

        initGame = obj.GetComponent<InitGame>();

        Debug.Log(judge);

        if (judge % 2 == 0)
        {
            initGame.img.texture = initGame.texture_list_tree[card_num];
            Debug.Log("Success!");
            Debug.Log(card_num);
        }
        else
        {
            initGame.img.texture = initGame.texture_list_tree[6];
            Debug.Log("Failed...");
        }
        Invoke("ShowInit", 3);
    }

    public void ShowInit()
    {
        InitGame initGame;
        GameObject obj = GameObject.Find("EventSystem");
        initGame = obj.GetComponent<InitGame>();
        initGame.img.texture = initGame.texture_list_init[0];
    }
}
