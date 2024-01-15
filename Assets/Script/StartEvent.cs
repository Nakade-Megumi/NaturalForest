using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

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
                EventFlower().Forget();
                break;
            case 1:
                EventTree().Forget();
                break;
            case 2:
                EventRiver().Forget();
                break;
            case 3:
                EventSea().Forget();
                break;
            default:
                break;
        }
    }

    public async UniTask EventFlower()
    {
        InitGame initGame_flower = GetInit();
        initGame_flower.img.texture = initGame_flower.texture_list_flower[0];
        await UniTask.Delay(2000);
        await JudgeFlowerEvent(initGame_flower);
    }

    public async UniTask EventTree()
    {
        InitGame initGame_tree = GetInit();
        initGame_tree.img.texture = initGame_tree.texture_list_tree[0];
        await UniTask.Delay(2000);
        await JudgeTreeEvent(initGame_tree);
    }

    public async UniTask EventRiver()
    {
        InitGame initGame_river = GetInit();
        initGame_river.img.texture = initGame_river.texture_list_river[0];
        await UniTask.Delay(2000);
        await JudgeRiverEvent(initGame_river);
    }

    public async UniTask EventSea()
    {
        InitGame initGame_sea = GetInit();
        initGame_sea.img.texture = initGame_sea.texture_list_sea[0];
        await UniTask.Delay(2000);
        await JudgeSeaEvent(initGame_sea);
    }

    public async UniTask JudgeFlowerEvent(InitGame initGame)
    {
        int judge = Random.Range(0, 10);
        int card_num = Random.Range(1, 4);

        Debug.Log(judge);
        //judge = 0;

        if (judge == 0 || judge == 10)
        {
            initGame.img.texture = initGame.texture_list_flower[7];
            Debug.Log("気合");
            await UniTask.Delay(3000);
            SceneManager.LoadScene("MiniGame");
        }
        else if (judge % 2 == 0)
        {
            initGame.img.texture = initGame.texture_list_flower[card_num];
            Debug.Log("Success!");
            Debug.Log(card_num);
            UpdateDatabase updateDatabase;
            GameObject obj = GameObject.Find("EventSystem");
            updateDatabase = obj.GetComponent<UpdateDatabase>();
            updateDatabase.IncrementNum(card_num - 1);
        }
        else
        {
            initGame.img.texture = initGame.texture_list_flower[6];
            Debug.Log("Failed...");
        }
        Invoke("ShowInit", 3);
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

    public async UniTask JudgeRiverEvent(InitGame initGame)
    {
        int judge = Random.Range(0, 10);
        int card_num = Random.Range(1, 4);

        Debug.Log(judge);
        //judge = 0;

        if (judge == 0 || judge == 10)
        {
            initGame.img.texture = initGame.texture_list_river[7];
            Debug.Log("気合");
            await UniTask.Delay(3000);
            SceneManager.LoadScene("MiniGame_2");
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

    public async UniTask JudgeSeaEvent(InitGame initGame)
    {
        int judge = Random.Range(0, 10);
        int card_num = Random.Range(1, 4);

        Debug.Log(judge);
        judge = 0;

        if (judge == 0 || judge == 10)
        {
            initGame.img.texture = initGame.texture_list_sea[7];
            Debug.Log("気合");
            await UniTask.Delay(3000);
            SceneManager.LoadScene("MiniGame_2");
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
}