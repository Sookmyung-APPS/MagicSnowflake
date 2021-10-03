using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class b : MonoBehaviour
{
    public Text buttonText;

    int scoreButton;

    [SerializeField] Texture2D cursorA;
    [SerializeField] Texture2D cursorB;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    private void Awake()
    {
        scoreButton = 0;
    }

    public void OnClickBasicButton()
    {
        scoreButton = scoreButton + 1;
        if (scoreButton == 5)
        {
            ChangeMouseAMode();
        }
        else if (scoreButton == 15)
            ChangeMouseBMode();
    }

    public void ChangeMouseAMode()
    {
        Cursor.SetCursor(cursorA, Vector2.zero, cursorMode);
    }

    public void ChangeMouseBMode()
    {
        Cursor.SetCursor(cursorB, Vector2.zero, cursorMode);
    }
}