namespace ParseTXT
{
    public class Answer
    {
        public string Text { get; set; }
        public bool Right { get; set; }
        public Answer(string text, bool right)
        {
            Text = text;
            Right = right;
        }
    }
}
