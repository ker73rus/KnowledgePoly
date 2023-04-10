using System.Collections.Generic;

namespace ParseTXT
{
    public class Question
    {
        public string Text { get; set; }
        public int Price { get; set; }
        public List<Answer> Answers { get; set; }
        public Question(string text, int price, List<Answer> answers)
        {
            Text = text;
            Price = price;
            Answers = answers;
        }
        public Question(string text, int price)
        {
            Text = text;
            Price = price;
        }

    }
}
