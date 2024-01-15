using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundDecision : MonoBehaviour
{
    public AudioClip sound_decision;
    AudioSource audioSource;

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    public void OnDecision()
    {
        //音を鳴らす
        audioSource.PlayOneShot(sound_decision);
    }
}
