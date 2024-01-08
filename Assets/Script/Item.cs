
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
[CreateAssetMenu(fileName = "Item", menuName="CreateItem")]
public class Item : ScriptableObject {

	public enum KindOfItem {
		Tree,
		Flower,
		sea,
		river
	}

	//　アイテムの種類
	[SerializeField]
	private KindOfItem kindOfItem;
	//　アイテムのアイコン
	[SerializeField]
	private Sprite icon;
	//　アイテムの名前
	[SerializeField]
	private string itemName;
	//　アイテムの情報
	[SerializeField]
	private string information;
	//　アイテムの数
	[SerializeField]
	private int quantity;

	public int Quantity {
        get { return quantity; }
        set { quantity = value; }
    }

	public KindOfItem GetKindOfItem() {
		return kindOfItem;
	}

	public Sprite GetIcon() {
		return icon;
	}

	public string GetItemName() {
		return itemName;
	}

	public string GetInformation() {
		return information;
	}

	// アイテムの数量を取得
    public int GetQuantity() {
        return quantity;
    }
}
