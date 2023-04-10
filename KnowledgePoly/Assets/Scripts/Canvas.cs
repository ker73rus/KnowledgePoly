using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas : MonoBehaviour
{
    [SerializeField]
    Text question_text;
    [SerializeField]
    Text[] answers_text;
    [SerializeField]
    Button[] answers_button;
    [SerializeField]
    GameObject wrongPanel;
    [SerializeField]
    GameObject rightPanel;
    [SerializeField]
    GameObject questPanel;
    [SerializeField]
    GameObject dicePanel;
    GameObject player;
    [SerializeField]
    Text dice;
    public bool quest = false;
    public bool diceBool = false;
    public void StartQuestion(GameObject player)
    {
        quest = true;
        this.player = player; 
        questPanel.SetActive(true);
        foreach(Button button in answers_button)
        {
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(RightAnswer);
        }
    }
    public void RightAnswer()
    {
        player.GetComponent<Player>().score+=100;
        StartCoroutine(right());
    }
    public void WrongAnswer() {
        StartCoroutine(wrong());
    }
    IEnumerator wrong()
    {
        wrongPanel.SetActive(true);
        yield return new WaitForSeconds(1f);
        wrongPanel.SetActive(false);
        questPanel.SetActive(false);
        quest = false;
    }
    IEnumerator right()
    {
        rightPanel.SetActive(true);
        yield return new WaitForSeconds(1f);
        rightPanel.SetActive(false);
        questPanel.SetActive(false);
        quest = false;
    }
    public IEnumerator DiceRoll(int k)
    {
        dicePanel.SetActive(true);
        diceBool = true;
        float t = 1.5f;
        dice.text = Random.Range(1, 7) + "";
        yield return new WaitForSeconds(t/6);
        dice.text = Random.Range(1, 7) + "";
        yield return new WaitForSeconds(t/5);
        dice.text = Random.Range(1, 7) + "";
        yield return new WaitForSeconds(t/4);
        dice.text = Random.Range(1, 7) + "";
        yield return new WaitForSeconds(t/3);
        dice.text = Random.Range(1, 7) + "";
        yield return new WaitForSeconds(t/2);
        dice.text = Random.Range(1, 7) + "";
        yield return new WaitForSeconds(t);
        dice.text = k + "";
        yield return new WaitForSeconds(1f);
        dicePanel.SetActive(false);
        diceBool = false;

    }
}
