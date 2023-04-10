using ParseTXT;
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
    Question curQuestion = new Question("Ошибка вопроса", 0, null);
    public void StartQuestion(GameObject player)
    {
        quest = true;
        this.player = player; 
        questPanel.SetActive(true);
        switch (player.GetComponent<Player>().curCell.GetComponent<CellScript>().theme)
        {
            case 0:
                curQuestion = Program.GetQuestionTheme1();
                break;
            case 1:
                curQuestion = Program.GetQuestionTheme2();
                break;
            case 2:
                curQuestion = Program.GetQuestionTheme3();
                break;
            case 3:
                curQuestion = Program.GetQuestionTheme4();
                break;
            default:
                curQuestion = new Question("Подарок, вам достается 100 очков", 100, new List<Answer> {new Answer("",true),new Answer("",true),new Answer("",true),new Answer("",true) });
                break;

        }
        question_text.text = curQuestion.Text;
        Answer[] answers = curQuestion.Answers.ToArray();
        foreach (Button button in answers_button)
        {
            button.onClick.RemoveAllListeners();
        }
        for (int i = 0; i < 4;i++) {
            answers_text[i].text = i==0 ? "A) " + answers[i].Text : i==1 ? "Б) " + answers[i].Text : i == 2 ? "B) " + answers[i].Text : "Г) " + answers[i].Text;
            if (answers[i].Right)
            {
                answers_button[i].onClick.AddListener(RightAnswer);
            }
            else
                answers_button[i].onClick.AddListener(WrongAnswer);
        }
        
        
    }
    public void RightAnswer()
    {
        player.GetComponent<Player>().score+=curQuestion.Price;
        StartCoroutine(right());
    }
    public void WrongAnswer() {
        player.GetComponent<Player>().score -= curQuestion.Price;
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
