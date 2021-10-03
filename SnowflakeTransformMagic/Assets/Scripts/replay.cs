using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class replay : MonoBehaviour
{

    public void toReplay()
    {
        SoundManager.instance.Click();
        SceneManager.LoadScene("InGame");

    }
}