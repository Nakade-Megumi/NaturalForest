
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Import Unity UI namespace

public class ItemManager : MonoBehaviour {

	//　アイテムデータベース
	[SerializeField]
	private ItemDataBase itemDataBase;

	//　アイテム数管理
	private Dictionary<Item, int> numOfItem = new Dictionary<Item, int>();

	//UI Text component for logs
    public Text logText;
	//public GameObject logText;

    // UI Image component for displaying an image
    public Image imageDisplay;

	// Use this for initialization
	void Start () {

		for (int i = 0; i < itemDataBase.GetItemLists().Count; i++) {
        // アイテム数を適当に設定
        numOfItem.Add (itemDataBase.GetItemLists() [i], i);
        // 確認の為データ出力
        string log = itemDataBase.GetItemLists()[i].GetItemName() + ": " + itemDataBase.GetItemLists()[i].GetQuantity() + "\n";
        Debug.Log(log);

        // Canvasにテキストを表示
        DisplayLog(log);
		}
	}

	//　名前でアイテムを取得
	public Item GetItem(string searchName) {
		return itemDataBase.GetItemLists().Find(itemName => itemName.GetItemName() == searchName);
	}

	// Method to display log in the UI Text
    void DisplayLog(string log)
    {
        if (logText != null)
        {
            logText.text += log + "\n"; // Append new log with a new line
        }
    }

    // Method to display image in the UI Image
    void DisplayImage(string imagePath)
    {
        if (imageDisplay != null)
        {
            // Load image from the Resources folder (adjust the path accordingly)
            Sprite sprite = Resources.Load<Sprite>(imagePath);
            if (sprite != null)
            {
                imageDisplay.sprite = sprite;
            }
        }
    }

}
