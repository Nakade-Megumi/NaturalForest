using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//マップ上の要素をクリックしたら，特定のイベントが発生する
public class ClickEvent : MonoBehaviour
{
    int click;

    public void OnFlower()
    {
        Debug.Log("click_event_flower");
        click = 0;
        StartEvent startEvent = gameObject.AddComponent<StartEvent>();
        startEvent.SearchEvent(click);
    }

    public void OnTree()
    {
        Debug.Log("click_event_tree");
        click = 1;
        StartEvent startEvent = gameObject.AddComponent<StartEvent>();
        startEvent.SearchEvent(click);
    }

    public void OnRiver()
    {
        Debug.Log("click_event_river");
        click = 2;
        StartEvent startEvent = gameObject.AddComponent<StartEvent>();
        startEvent.SearchEvent(click);
    }

    public void OnSea()
    {
        Debug.Log("click_event_sea");
        click = 3;
        StartEvent startEvent = gameObject.AddComponent<StartEvent>();
        startEvent.SearchEvent(click);

    }

    public void OnHouse()
    {
        Debug.Log("click_event_house");
    }

}