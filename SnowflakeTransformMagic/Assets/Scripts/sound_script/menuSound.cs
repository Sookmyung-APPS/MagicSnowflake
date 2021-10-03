using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuSound : MonoBehaviour
{
    GameObject BackgroundMusic;
    AudioSource backmusic;

    void Awake()
    {
        BackgroundMusic = GameObject.Find("BGM");
        backmusic = BackgroundMusic.GetComponent<AudioSource>(); //배경음악 저장해둠
        DontDestroyOnLoad(backmusic);

        Debug.Log(SceneManager.GetActiveScene().name);

        if (SceneManager.GetActiveScene().name == "InGame")
        {
            BackGroundMusicOffButton();
        }
        if (SceneManager.GetActiveScene().name == "Howtoplay")
        {
            if (backmusic.isPlaying) return;
            else
            {
                backmusic.Play();
                Debug.Log("처음시작");
            }
        }

        else if (SceneManager.GetActiveScene().name == "Menu")
        {
            if (backmusic.isPlaying) return; //배경음악이 재생되고 있다면 패스
            else
            {
                backmusic.Play();
                Debug.Log("시작");
            }

        }
    }

    public void BackGroundMusicOffButton() //배경음악 키고 끄는 버튼
    {
        BackgroundMusic = GameObject.Find("BGM");
        backmusic = BackgroundMusic.GetComponent<AudioSource>(); //배경음악 저장해둠
        backmusic.Stop();
    }
}