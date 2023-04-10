using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CellScript : MonoBehaviour
{
    string quest = "";
    string[] answers;
    public GameObject nextCell;
    [SerializeField]
    Text text;
    [SerializeField]
    SpriteRenderer sprite;
    public int theme = 0;
    // Start is called before the first frame update

    private void Start()
    {
        
        switch (theme)
        {
            case 0:
                sprite.color = new Color32(254,214,188,255);
                break;
            case 1:
                sprite.color = new Color32(255, 155, 170, 255);
                break;
            case 2:
                sprite.color = new Color32(127, 181, 181, 255);
                break;
            case 3:
                sprite.color = new Color32(172, 225, 175, 255);
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
