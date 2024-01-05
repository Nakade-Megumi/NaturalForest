using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitGame : MonoBehaviour
{
    [SerializeField] private GameObject eventCard;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start_card");
        eventCard.SetActive(false);
    }
}
