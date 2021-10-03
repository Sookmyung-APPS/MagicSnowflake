using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toHowtoplay : MonoBehaviour
{
    public void toHow()
    {
        SoundManager.instance.Click();
        SceneManager.LoadScene("Howtoplay");
    }
}