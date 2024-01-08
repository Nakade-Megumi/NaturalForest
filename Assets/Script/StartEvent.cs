using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
                EventTree().Forget();
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
    }

    public async UniTask EventTree()
    {
        InitGame initGame_tree = GetInit();
        initGame_tree.img.texture = initGame_tree.texture_list_tree[0];
        await UniTask.Delay(2000);
        await JudgeTreeEvent(initGame_tree);
    }

    public void EventRiver()
    {
        InitGame initGame_river = GetInit();
        initGame_river.img.texture = initGame_river.texture_list_river[0];

    }

    public void EventSea()
    {
        InitGame initGame_sea = GetInit();
        initGame_sea.img.texture = initGame_sea.texture_list_sea[0];

    }

    public async UniTask JudgeTreeEvent(InitGame initGame)
    {
        int judge = Random.Range(0, 10);
        int card_num = Random.Range(1, 4);

        Debug.Log(judge);
        //judge = 0;

        if (judge == 0 || judge == 10)
        {
            initGame.img.texture = initGame.texture_list_tree[7];
            Debug.Log("気合");
            await UniTask.Delay(3000);
            SceneManager.LoadScene("MiniGame");
        }
        else if (judge % 2 == 0)
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
}