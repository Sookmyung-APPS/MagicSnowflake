using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toBack : MonoBehaviour
{
    public void toMenu()
    {
        SoundManager.instance.Click();
        SceneManager.LoadScene("Menu");
    }
}