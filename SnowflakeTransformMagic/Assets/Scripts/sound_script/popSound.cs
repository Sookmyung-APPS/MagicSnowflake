using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popSound : MonoBehaviour
{
    public static popSound instance;
    [SerializeField] AudioSource audioSource;

    [SerializeField] AudioClip click;

    void Awake()
    {
        instance = this;
    }

    public void Click()
    {
        audioSource.PlayOneShot(click);
    }
}
