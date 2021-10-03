using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boilSound : MonoBehaviour
{
    public static boilSound instance;
    [SerializeField] AudioSource audioSource;

    [SerializeField] AudioClip click;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;

        DontDestroyOnLoad(gameObject);
    }

    public void Click()
    {
        audioSource.PlayOneShot(click);
    }
    public void fin()
    {
        audioSource.Stop();
    }
}

