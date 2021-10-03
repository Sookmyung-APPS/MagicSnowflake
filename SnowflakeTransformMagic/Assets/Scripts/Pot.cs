using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pot : MonoBehaviour
{
    public int plant;
    public int liquid;
    public int powder;
    public int book;
    public int cake;
    public int color;

    public GameObject Hint;
    public Button btnHint;

    public GameObject invLiquidA;
    public GameObject invLiquidB;
    public GameObject invPowderA;
    public GameObject invPowderB;
    public GameObject invColorA;
    public GameObject invColorB;
    public GameObject invColorC;
    public GameObject invPlantA;
    public GameObject invPlantB;
    public GameObject invPlantC;
    public GameObject invBookA;
    public GameObject invBookB;
    public GameObject invBookC;
    public GameObject invCakeA;
    public GameObject invCakeB;

    public GameObject replayButton;
    public GameObject howtoplayButton;

    public GameObject result1;
    public GameObject result2;
    public GameObject result3;
    public GameObject result4;
    public GameObject result5;
    public GameObject result6;
    public GameObject result7;
    public GameObject result8;
    public GameObject result9;
    public GameObject result10;
    public GameObject result11;
    public GameObject result12;
    public GameObject result13;
    public GameObject result14;
    public GameObject result15;

    public GameObject Stop;
    public GameObject boil1;
    public GameObject boil2;
    public GameObject boil3;
    public GameObject boil4;
    public GameObject boil5;
    public GameObject boil6;

    public Shake shake;

    void Start()
    {
        Hint.SetActive(false);
        invLiquidA.SetActive(false);
        invLiquidB.SetActive(false);
        invPowderA.SetActive(false);
        invPowderB.SetActive(false);
        invColorA.SetActive(false);
        invColorB.SetActive(false);
        invColorC.SetActive(false);
        invPlantA.SetActive(false);
        invPlantB.SetActive(false);
        invPlantC.SetActive(false);
        invBookA.SetActive(false);
        invBookB.SetActive(false);
        invBookC.SetActive(false);
        invCakeA.SetActive(false);
        invCakeB.SetActive(false);

        replayButton.SetActive(false);
        howtoplayButton.SetActive(false);

        result1.SetActive(false);
        result2.SetActive(false);
        result3.SetActive(false);
        result4.SetActive(false);
        result5.SetActive(false);
        result6.SetActive(false);
        result7.SetActive(false);
        result8.SetActive(false);
        result9.SetActive(false);
        result10.SetActive(false);
        result11.SetActive(false);
        result12.SetActive(false);
        result13.SetActive(false);
        result14.SetActive(false);
        result15.SetActive(false);

        Stop.SetActive(false);
        boil1.SetActive(false);
        boil2.SetActive(false);
        boil3.SetActive(false);
        boil4.SetActive(false);
        boil5.SetActive(false);
        boil6.SetActive(false);
    }
   
    public void Click()
    {
        SoundManager.instance.Click();
        if (plant == 0 || liquid == 0 || powder == 0 || book == 0 || cake == 0 || color == 0)
        {
            shake.Todo(50);
            Hint.SetActive(true);
            Invoke("HideHint", 2);
            
        }
        else
        {
            Stop.SetActive(true);
            boilSound.instance.Click();
            Invoke("show1", 0.3f);
        }
    }

    public void result()
    {
        popSound.instance.Click();
        Invoke("WaitButton", 2);
        if (powder == 20 && liquid == 10 && cake == 10 && plant == 20 && color == 20 && book == 30)
            result15.SetActive(true);
        else if (powder == 20)
            result1.SetActive(true);
        else if (liquid == 20)
            result2.SetActive(true);
        else if (cake == 10)
            result3.SetActive(true);
        else if (plant == 10)
            result4.SetActive(true);
        else if (plant == 20)
            result5.SetActive(true);
        else if (color == 10 && book == 10)
            result6.SetActive(true);
        else if (color == 20 && book == 10)
            result7.SetActive(true);
        else if (color == 30 && book == 10)
            result8.SetActive(true);
        else if (color == 10 && book == 20)
            result9.SetActive(true);
        else if (color == 20 && book == 20)
            result10.SetActive(true);
        else if (color == 30 && book == 20)
            result11.SetActive(true);
        else if (color == 10 && book == 30)
            result12.SetActive(true);
        else if (color == 20 && book == 30)
            result13.SetActive(true);
        else if (color == 30 && book == 30)
            result14.SetActive(true);
        else
            Debug.Log("오류");

    }

    void show1()
    {
        boil1.SetActive(true);
        Invoke("show2", 0.3f);
    }
    void show2()
    {
        boil2.SetActive(true);
        Invoke("show3", 0.3f);
    }
    void show3()
    {
        boil3.SetActive(true);
        Invoke("show4", 0.3f);
    }
    void show4()
    {
        boil4.SetActive(true);
        Invoke("show5", 0.3f);
    }
    void show5()
    {
        boil6.SetActive(false);
        boil5.SetActive(true);
        Invoke("show6", 0.3f);
    }
    void show6()
    {
        boil5.SetActive(false);
        boil6.SetActive(true);
        Invoke("show7", 0.3f);
    }
    void show7()
    {
        boil6.SetActive(false);
        boil5.SetActive(true);
        Invoke("show8", 0.3f);
    }
    void show8()
    {
        boil5.SetActive(false);
        boil6.SetActive(true);
        Invoke("show9", 0.3f);
    }
    void show9()
    {
        boil6.SetActive(false);
        boil5.SetActive(true);
        Invoke("show10", 0.3f);
    }
    void show10()
    {
        boil5.SetActive(false);
        boil6.SetActive(true);
        boilSound.instance.fin();
        result();
    }

    void HideHint()
    {
        Hint.SetActive(false);
    }

    void WaitButton()
    {
        replayButton.SetActive(true);
        howtoplayButton.SetActive(true);
    }
        
}
