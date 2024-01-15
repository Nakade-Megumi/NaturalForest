using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundDecision : MonoBehaviour
{
    public AudioClip sound_se;
    AudioSource audioSource;

    public static SoundDecision Instance {
        get; private set;
    }

    void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    public void OnDecision()
    {
        //音を鳴らす
        audioSource.PlayOneShot(sound_se);
    }
}
