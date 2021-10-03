using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Item : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    public Canvas canvas;
    public GraphicRaycaster gr;
    public RectTransform panelRectTransform;

    public int index=0;

    public int plant;
    public int liquid;
    public int powder;
    public int book;
    public int cake;
    public int color;

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

    public Pot pot;

    Vector2 originPosition;

    public void start()
    {
    }
    void update()
    {
    }

    public void OnPointerDown(PointerEventData ped)
    {

        index = panelRectTransform.GetSiblingIndex();
        originPosition = transform.position;
    }

    public void OnDrag(PointerEventData ped)
    {
        transform.position = ped.position;
        panelRectTransform.SetAsLastSibling();
    }
   

    public void OnPointerUp(PointerEventData ped)
    {

        Pot obj = null;
        List<RaycastResult> results = new List<RaycastResult>();
        gr.Raycast(ped, results);


        foreach (RaycastResult result in results)
        {
            if (result.gameObject == gameObject)
                continue;

            Pot temp = result.gameObject.GetComponent<Pot>();
            if (temp != null)
            {
                obj = temp;
                break;
            }
        }

        //항아리가 있을때
        if (obj != null)
        {

            putSound.instance.play();
            pot.shake.Todo(10);
            //Debug.Log("원래 값 " + obj.variable);
            if (book != 0)
                obj.book = book;
            if (plant != 0)
                obj.plant = plant;
            if (color != 0)
                obj.color = color;
            if (powder != 0)
                obj.powder = powder;
            if (liquid != 0)
                obj.liquid = liquid;
            if (cake != 0)
                obj.cake = cake;

            if (obj.book == 10)
            {
                invBookA.SetActive(true);
                invBookB.SetActive(false);
                invBookC.SetActive(false);
            }
            else if (obj.book == 20)
            {
                invBookA.SetActive(false);
                invBookB.SetActive(true);
                invBookC.SetActive(false);
            }
            else if (obj.book == 30)
            {
                invBookA.SetActive(false);
                invBookB.SetActive(false);
                invBookC.SetActive(true);
            }

            if (obj.plant == 10)
            {
                invPlantA.SetActive(true);
                invPlantB.SetActive(false);
                invPlantC.SetActive(false);

            }
            else if (obj.plant == 20)
            {
                invPlantA.SetActive(false);
                invPlantB.SetActive(true);
                invPlantC.SetActive(false);
            }
            else if (obj.plant == 30)
            {
                invPlantA.SetActive(false);
                invPlantB.SetActive(false);
                invPlantC.SetActive(true);
            }

            if (obj.color == 10)
            {
                invColorA.SetActive(true);
                invColorB.SetActive(false);
                invColorC.SetActive(false);
            }
            else if (obj.color == 20)
            {
                invColorA.SetActive(false);
                invColorB.SetActive(true);
                invColorC.SetActive(false);
            }
            else if (obj.color == 30)
            {
                invColorA.SetActive(false);
                invColorB.SetActive(false);
                invColorC.SetActive(true);
            }

            if (obj.powder == 10)
            {
                invPowderA.SetActive(true);
                invPowderB.SetActive(false);
            }
            else if (obj.powder == 20)
            {
                invPowderA.SetActive(false);
                invPowderB.SetActive(true);
            }

            if (obj.liquid == 10)
            {
                invLiquidA.SetActive(true);
                invLiquidB.SetActive(false);
            }
            else if (obj.liquid == 20)
            {
                invLiquidA.SetActive(false);
                invLiquidB.SetActive(true);
            }

            if (obj.cake == 10)
            {
                invCakeA.SetActive(true);
                invCakeB.SetActive(false);
            }
            else if (obj.cake == 20)
            {
                invCakeA.SetActive(false);
                invCakeB.SetActive(true);
            }

            StartCoroutine(Fade(gameObject, 0.8f));
            Invoke("Hide", 0.7f);

        }
        else
        {
            transform.position = originPosition;
            panelRectTransform.SetSiblingIndex(index);
        }


    }
    void Hide()
    {
        transform.position = originPosition;
        panelRectTransform.SetSiblingIndex(index);
    }


    IEnumerator Fade(GameObject obj, float duration)
    {
        Image image = obj.GetComponent<Image>();
        image.raycastTarget = false;
        float elapsed = 0;
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;

            Color c = image.color;
            c.a = Mathf.Lerp(1, 0, elapsed / duration);

            image.color = c;
            yield return null;
        }
        Color color = image.color;
        color.a = 1f;
        image.color = color;
        image.raycastTarget = true;
    }
}