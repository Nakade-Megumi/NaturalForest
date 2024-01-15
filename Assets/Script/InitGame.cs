using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class InitGame : MonoBehaviour
{
    //表示させる画像オブジェクトのRaw画像コンポーネント
    public RawImage img;
    //表示させる画像リスト
    public List<Texture> texture_list_init = new List<Texture>();
    public List<Texture> texture_list_tree = new List<Texture>();
    public List<Texture> texture_list_flower = new List<Texture>();
    public List<Texture> texture_list_river = new List<Texture>();
    public List<Texture> texture_list_sea = new List<Texture>();

    //　アイテムデータベース
    [SerializeField]
    private ItemDataBase itemDataBase_flower;

    //　アイテム数管理
    //private Dictionary<Item, int> numOfItem = new Dictionary<Item, int>();

    public Text logText;

    void Start()
    {
        img = GameObject.Find("DisplayImage").GetComponent<RawImage>();
        //画像を読み込む
        ReadImg();
        //Debug.Log(texture_list_tree[0]);
        InitDatabase();
        Debug.Assert(itemDataBase_flower);
    }

    public void ReadImg()
    {
        Texture tmp;
        string[] spot = { "tree" , "flower", "river", "sea"};
        int i = 0;

        //非表示用画面の読み込み
        tmp = Resources.Load("Image/event/init") as Texture;
        texture_list_init.Add(tmp);

        foreach (string s in spot)
        {
            //Debug.Log(File.Exists("Assets/Resources/Image/event/" + s + "_" + i + ".png"));
            while (File.Exists("Assets/Resources/Image/event/" + s + "_" + i + ".png"))
            {
                //Debug.Log(s + "_" + i);
                tmp = Resources.Load("Image/event/" + s + "_" + i) as Texture;

                switch (s)
                {
                    case "tree":
                        texture_list_tree.Add(tmp);
                        break;
                    case "flower":
                        texture_list_flower.Add(tmp); 
                        break;
                    case "river":
                        texture_list_river.Add(tmp); 
                        break;
                    case "sea":
                        texture_list_sea.Add(tmp);
                        break;
                    default: break;
                }
                i++;
            }
            i= 0;
        }
    }

    //DBの初期化
    public void InitDatabase()
    {
        //データベース
        for (int i = 0; i < itemDataBase_flower.GetItemLists().Count; i++)
        {
            // アイテム数を適当に設定
            //numOfItem.Add(itemDataBase.GetItemLists()[i], i);
            // 確認の為データ出力
            string log = itemDataBase_flower.GetItemLists()[i].GetItemName() + ": " + itemDataBase_flower.GetItemLists()[i].GetQuantity();
            Debug.Log(log);
            //Debug.Log(numOfItem);
            Debug.Log(itemDataBase_flower.GetItemLists()[i]);
            DisplayLog(itemDataBase_flower.GetItemLists()[i].GetItemName() + ": " + itemDataBase_flower.GetItemLists()[i].GetQuantity() + "\n");

        }

    }

    void DisplayLog(string log)
    {
        if (logText != null)
        {
            logText.text += log + "\n"; // Append new log with a new line
        }
    }

}