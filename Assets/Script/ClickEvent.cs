using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//マップ上の要素をクリックするとイベント発生
public class ClickEvent : MonoBehaviour
{
    int click;

    public void SetSound()
    {
        SoundDecision soundDecision = SoundDecision.Instance;
        soundDecision.OnDecision();
    }

    public void OnFlower()
    {
        SetSound();
        Debug.Log("click_event_flower");
        click = 0;
        StartEvent startEvent = gameObject.AddComponent<StartEvent>();
        startEvent.SearchEvent(click);
    }

    public void OnTree()
    {
        SetSound();
        Debug.Log("click_event_tree");
        click = 1;
        StartEvent startEvent = gameObject.AddComponent<StartEvent>();
        startEvent.SearchEvent(click);
    }

    public void OnRiver()
    {
        SetSound();
        Debug.Log("click_event_river");
        click = 2;
        StartEvent startEvent = gameObject.AddComponent<StartEvent>();
        startEvent.SearchEvent(click);
    }

    public void OnSea()
    {
        SetSound();
        Debug.Log("click_event_sea");
        click = 3;
        StartEvent startEvent = gameObject.AddComponent<StartEvent>();
        startEvent.SearchEvent(click);

    }

    public void OnHouse()
    {
        SetSound();
        Debug.Log("click_event_house");
        //SceneManager.LoadScene("Collection");
        this.transform.localPosition = new Vector2(-2000, 0);
    }

    public void OnBack()
    {
        SetSound();
        Debug.Log("click_back");
        SceneManager.LoadScene("Title");
    }
}