using ParseTXT;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    [SerializeField]
    GameObject move;
    [SerializeField]
    Text[] scores = new Text[4];
    [SerializeField]
    GameObject[] Players = new GameObject[4];
    GameObject StartCell;
    [SerializeField]
    GameObject canvas;
    int curPlayer = 0;
    [SerializeField]
    private GameObject CellPrefab;
    public GameObject[] map;




    public void Generate(int X)
    {
        map = new GameObject[X];
        int x = -5;
        float y = 4.5f;
        for(int i =0; i < map.Length;i++)
        {
            map[i] = Instantiate(CellPrefab,new Vector3(x,y,0), Quaternion.identity);
            if(i < 9)
            {
                map[i].GetComponent<CellScript>().theme = 1;
                x++;
            }
            else if(i < 18)
            {
                if(i == 9)
                    map[i].GetComponent<CellScript>().theme = -1;
                else
                    map[i].GetComponent<CellScript>().theme = 2;
                y--;
            }
            else if(i < 27)
            {
                if(i == 18)
                    map[i].GetComponent<CellScript>().theme = -1;
                else
                    map[i].GetComponent<CellScript>().theme = 3;
                x--;
            }
            else if(i < 35)
            {
                if(i == 27)
                    map[i].GetComponent<CellScript>().theme = -1;
                else
                    map[i].GetComponent<CellScript>().theme = 0;
                y++;
            }
        }
        StartCell = map[0];
        StartCell.GetComponent<CellScript>().TextChange("Start");
        for(int i = 0; i < map.Length; i++)
        {
            if(i < 35)
                map[i].GetComponent<CellScript>().SetNext(map[i+1]);
            else
                map[i].GetComponent<CellScript>().SetNext(map[0]);
        }
    }

    private void Start()
    {
        Program.Main();
        Generate(36);
        for(int i = 0; i < Players.Length; i++)
        {
            Players[i] = Instantiate(Players[i], new Vector3(StartCell.transform.position.x, StartCell.transform.position.y, 0), Quaternion.identity,StartCell.transform);
            Players[i].GetComponent<Player>().num = i;
            Players[i].GetComponent<Player>().SetCell(StartCell);
            
        }
        ScoreUpdate();
    }
    void PlayerSwitch()
    {
        if (curPlayer == Players.Length - 1)
            curPlayer = 0;
        else curPlayer++;
        Color color;
        switch (curPlayer)
        {
            case 0:
                ColorUtility.TryParseHtmlString("#E55454", out color);
                move.GetComponent<Image>().color = color;
                move.GetComponentInChildren<Text>().text = "Ход игрока №1";
                break;
            case 1:
                ColorUtility.TryParseHtmlString("#54E5DA", out color);
                move.GetComponent<Image>().color = color;
                move.GetComponentInChildren<Text>().text = "Ход игрока №2";
                break;
            case 2:
                ColorUtility.TryParseHtmlString("#8BE554", out color);
                move.GetComponent<Image>().color = color;
                move.GetComponentInChildren<Text>().text = "Ход игрока №3";
                break;
            case 3:
                ColorUtility.TryParseHtmlString("#E5D254", out color);
                move.GetComponent<Image>().color = color;
                move.GetComponentInChildren<Text>().text = "Ход игрока №4";
                break;
        }

    }
    public void NextMotion()
    {
        int k = Random.Range(1, 7);
        StartCoroutine(canvas.GetComponent<Canvas>().DiceRoll(k));       
        StartCoroutine(Question(k)); 
    }
    IEnumerator Question(int k)
    {
        yield return new WaitUntil(() => canvas.GetComponent<Canvas>().diceBool == false);
        Players[curPlayer].GetComponent<Player>().NextCell(k);
        yield return new WaitForSeconds(1);
        canvas.GetComponent<Canvas>().StartQuestion(Players[curPlayer]);
        yield return new WaitUntil(() => canvas.GetComponent<Canvas>().quest == false);
        ScoreUpdate();
        PlayerSwitch();
    }
    public void ScoreUpdate()
    {
        for(int i = 0;i < Players.Length;i++) {
            scores[i].text = "Score: " + Players[i].GetComponent<Player>().score;
        }
    }
}
