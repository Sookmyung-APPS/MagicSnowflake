using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toPlay : MonoBehaviour
{
    public void toInGame()
    {
        SoundManager.instance.Click();
        SceneManager.LoadScene("InGame");
    }
}
