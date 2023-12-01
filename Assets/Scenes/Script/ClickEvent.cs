using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//マップ上の要素をクリックしたら，特定のイベントが発生する
public class ClickEvent : MonoBehaviour
{
    public void OnFlower()
    {
        Debug.Log("click_event_flower");
    }

    public void OnTree()
    {
        Debug.Log("click_event_tree");
    }

    public void OnPond()
    {
        Debug.Log("click_event_pond");
    }

    public void OnRiver()
    {
        Debug.Log("click_event_river");
    }

    public void OnHouse()
    {
        Debug.Log("click_event_house");
    }

}
