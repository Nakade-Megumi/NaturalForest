using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class UpdateDatabase : MonoBehaviour
{
    //　アイテムデータベース
    [SerializeField]
    private ItemDataBase itemDataBase;

    //　アイテム数管理
    //private Dictionary<Item, int> numOfItem = new Dictionary<Item, int>();

    public void IncrementNum(int item_num)
    {  
        itemDataBase.GetItemLists()[item_num].Quantity = itemDataBase.GetItemLists()[item_num].GetQuantity() + 1;
        Debug.Log(itemDataBase.GetItemLists()[item_num].GetItemName() + ": "+ itemDataBase.GetItemLists()[item_num].Quantity);
    }
}
