<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartEvent : MonoBehaviour
{
    public InitGame GetInit()
    {
        InitGame init;
        GameObject obj = GameObject.Find("EventSystem");
        init = obj.GetComponent<InitGame>();
        return init;
    }

    public void ShowInit()
    {
        InitGame initGame = GetInit();
        initGame.img.texture = initGame.texture_list_init[0];
    }

    public void SearchEvent(int click)
    {
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
        InitGame initGame_flower = GetInit();
        initGame_flower.img.texture = initGame_flower.texture_list_flower[0];
        Invoke("JudgeFlowerEvent", 2);
    }

    public void EventTree()
    {
        InitGame initGame_tree = GetInit();
        initGame_tree.img.texture = initGame_tree.texture_list_tree[0];
        Invoke("JudgeTreeEvent", 2);
    }

    public void EventRiver()
    {
        InitGame initGame_river = GetInit();
        initGame_river.img.texture = initGame_river.texture_list_river[0];
        Invoke("JudgeRiverEvent", 2);
    }

    public void EventSea()
    {
        InitGame initGame_sea = GetInit();
        initGame_sea.img.texture = initGame_sea.texture_list_sea[0];
        Invoke("JudgeSeaEvent", 2);

    }

    public void JudgeFlowerEvent()
    {
        InitGame initGame = GetInit();
        int judge = Random.Range(1, 6);
        int card_num = Random.Range(1, 6);

        Debug.Log(judge);

        if (judge == 0 || judge == 10)
        {
            initGame.img.texture = initGame.texture_list_flower[7];
            Debug.Log("気合");
        }
        else if (judge % 2 == 0)
        {
            initGame.img.texture = initGame.texture_list_flower[card_num];
            Debug.Log("Success!");
            Debug.Log(card_num);
        }
        else
        {
            initGame.img.texture = initGame.texture_list_flower[6];
            Debug.Log("Failed...");
        }
        Invoke("ShowInit", 3);
    }

    public void JudgeTreeEvent()
    {
        InitGame initGame = GetInit();
        int judge = Random.Range(1, 9);
        int card_num = Random.Range(1, 9);

        Debug.Log(judge);

        if (judge == 0 || judge == 10)
        {
            initGame.img.texture = initGame.texture_list_tree[10];
            Debug.Log("気合");
        }
        else if (judge % 2 == 0)
        {
            initGame.img.texture = initGame.texture_list_tree[card_num];
            Debug.Log("Success!");
            Debug.Log(card_num);
        }
        else
        {
            initGame.img.texture = initGame.texture_list_tree[9];
            Debug.Log("Failed...");
        }
        Invoke("ShowInit", 3);
    }

    public void JudgeRiverEvent()
    {
        InitGame initGame = GetInit();
        int judge = Random.Range(1, 6);
        int card_num = Random.Range(1, 6);

        Debug.Log(judge);

        if (judge == 0 || judge == 10)
        {
            initGame.img.texture = initGame.texture_list_river[7];
            Debug.Log("気合");
        }
        else if (judge % 2 == 0)
        {
            initGame.img.texture = initGame.texture_list_river[card_num];
            Debug.Log("Success!");
            Debug.Log(card_num);
        }
        else
        {
            initGame.img.texture = initGame.texture_list_river[6];
            Debug.Log("Failed...");
        }
        Invoke("ShowInit", 3);
    }

    public void JudgeSeaEvent()
    {
        InitGame initGame = GetInit();
        int judge = Random.Range(1, 6);
        int card_num = Random.Range(1, 6);

        Debug.Log(judge);

        if (judge == 0 || judge == 10)
        {
            initGame.img.texture = initGame.texture_list_sea[7];
            Debug.Log("気合");
        }
        else if (judge % 2 == 0)
        {
            initGame.img.texture = initGame.texture_list_sea[card_num];
            Debug.Log("Success!");
            Debug.Log(card_num);
        }
        else
        {
            initGame.img.texture = initGame.texture_list_sea[6];
            Debug.Log("Failed...");
        }
        Invoke("ShowInit", 3);
    }
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartEvent : MonoBehaviour
{
    public InitGame GetInit()
    {
        InitGame init;
        GameObject obj = GameObject.Find("EventSystem");
        init = obj.GetComponent<InitGame>();
        return init;
    }

    public void ShowInit()
    {
        InitGame initGame = GetInit();
        initGame.img.texture = initGame.texture_list_init[0];
    }

    public void SearchEvent(int click)
    {
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
        InitGame initGame_flower = GetInit();
        initGame_flower.img.texture = initGame_flower.texture_list_flower[0];
        Invoke("JudgeFlowerEvent",2);
    }

    public void EventTree()
    {
        InitGame initGame_tree = GetInit();
        initGame_tree.img.texture = initGame_tree.texture_list_tree[0];
        Invoke("JudgeTreeEvent",2);
    }
    
    public void EventRiver()
    {
        InitGame initGame_river = GetInit();
        initGame_river.img.texture = initGame_river.texture_list_river[0];
        Invoke("JudgeRiverEvent",2);
    }

    public void EventSea()
    {
        InitGame initGame_sea = GetInit();
        initGame_sea.img.texture = initGame_sea.texture_list_sea[0];
        Invoke("JudgeSeaEvent",2);

    }

    public void JudgeFlowerEvent() {
        InitGame initGame = GetInit();
        int judge = Random.Range(1, 6);
        int card_num = Random.Range(1,6);

        Debug.Log(judge);

        if(judge == 0 || judge == 10) 
        {
            initGame.img.texture = initGame.texture_list_flower[7];
            Debug.Log("気合");
        }
        else if (judge % 2 == 0)
        {
            initGame.img.texture = initGame.texture_list_flower[card_num];
            Debug.Log("Success!");
            Debug.Log(card_num);
        }
        else
        {
            initGame.img.texture = initGame.texture_list_flower[6];
            Debug.Log("Failed...");
        }
        Invoke("ShowInit", 3);
    }

    public void JudgeTreeEvent() {
        InitGame initGame = GetInit();
        int judge = Random.Range(1, 9);
        int card_num = Random.Range(1,9);

        Debug.Log(judge);

        if(judge == 0 || judge == 10) 
        {
            initGame.img.texture = initGame.texture_list_tree[10];
            Debug.Log("気合");
        }
        else if (judge % 2 == 0)
        {
            initGame.img.texture = initGame.texture_list_tree[card_num];
            Debug.Log("Success!");
            Debug.Log(card_num);
        }
        else
        {
            initGame.img.texture = initGame.texture_list_tree[9];
            Debug.Log("Failed...");
        }
        Invoke("ShowInit", 3);
    }

    public void JudgeRiverEvent() {
        InitGame initGame = GetInit();
        int judge = Random.Range(1, 6);
        int card_num = Random.Range(1,6);

        Debug.Log(judge);

        if(judge == 0 || judge == 10) 
        {
            initGame.img.texture = initGame.texture_list_river[7];
            Debug.Log("気合");
        }
        else if (judge % 2 == 0)
        {
            initGame.img.texture = initGame.texture_list_river[card_num];
            Debug.Log("Success!");
            Debug.Log(card_num);
        }
        else
        {
            initGame.img.texture = initGame.texture_list_river[6];
            Debug.Log("Failed...");
        }
        Invoke("ShowInit", 3);
    }

    public void JudgeSeaEvent() {
        InitGame initGame = GetInit();
        int judge = Random.Range(1, 6);
        int card_num = Random.Range(1,6);

        Debug.Log(judge);

        if(judge == 0 || judge == 10) 
        {
            initGame.img.texture = initGame.texture_list_sea[7];
            Debug.Log("気合");
        }
        else if (judge % 2 == 0)
        {
            initGame.img.texture = initGame.texture_list_sea[card_num];
            Debug.Log("Success!");
            Debug.Log(card_num);
        }
        else
        {
            initGame.img.texture = initGame.texture_list_sea[6];
            Debug.Log("Failed...");
        }
        Invoke("ShowInit", 3);
    }
>>>>>>> origin/morii_v3
}