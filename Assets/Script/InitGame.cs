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

    void Start()
    {
        img = GameObject.Find("DisplayImage").GetComponent<RawImage>();
        //画像を読み込む
        ReadImg();
        //Debug.Log(texture_list_tree[0]);
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
}
