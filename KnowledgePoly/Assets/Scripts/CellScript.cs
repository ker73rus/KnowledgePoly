using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CellScript : MonoBehaviour
{
    public string quest = "";
    public string[] answers;
    public GameObject nextCell;
    [SerializeField]
    private Text text;
    [SerializeField]
    private SpriteRenderer sprite;
    public int theme = 0;
    // Start is called before the first frame update

    private void Start()
    {
        switch (theme)
        {
            case 0:
                sprite.color = Color.gray;
                break;
            case 1:
                sprite.color = Color.magenta;
                break;
            case 2:
                sprite.color = Color.cyan;
                break;
            case 3:
                sprite.color = Color.blue;
                break;
            default:
                break;
               
        }
    }
    public void TextChange(string s)
    {
        if (s == "Start")
        {
            text.fontSize = 35;
            theme = -1;
        }
            
        text.text = s;
    }
    public void SetNext(GameObject next)
    {
        nextCell = next;
    }
}
