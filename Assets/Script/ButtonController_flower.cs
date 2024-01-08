using UnityEngine;
using UnityEngine.UI;

public class ButtonController_flower : MonoBehaviour
{
    public GameObject imagePrefab; // event.pngを表示するためのImageプレハブ
    private GameObject currentImage;

    

    public void OnFlowerButtonClick()
    {
        // ボタンがクリックされたときの処理
        if (currentImage == null)
        {
            // event.pngの表示
            currentImage = Instantiate(imagePrefab, transform);
            // 3秒後に画像を非表示にする
            Destroy(currentImage, 3f);
        }
    }
}
