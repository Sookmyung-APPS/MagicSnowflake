using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class putSound : MonoBehaviour
{
    public static putSound instance;
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

    public void play()
    {
        audioSource.PlayOneShot(click);
    }
}
