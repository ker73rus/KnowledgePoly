using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTXT
{
    public static class Program
    {
        static Question[] questionsTheme1;
        static Question[] questionsTheme2;
        static Question[] questionsTheme3;
        static Question[] questionsTheme4;
        static int i = 0;
        public static void Main()
        {
            ParseFirst();
            ParseSecond();
            ParseThird();
            ParseFourth();
        }

        static void ParseFirst()
        {
            List<Question> Firstlist = new List<Question>();
            StreamReader f = new StreamReader("first.txt");
            int k = 0;
            string text = "";
            int price = 0;
            List<Answer> answer = new List<Answer>();
            while (!f.EndOfStream)
            {
                k++;
                string s = f.ReadLine();
                switch (k % 6)
                {
                    case 1:
                        text = s;
                        break;
                    case 2:
                        price = int.Parse(s);
                        break;
                    case 3:
                        if (s[0] == '1')
                        {
                            answer.Add(new Answer(s.Substring(1, s.Length - 1), true));
                        }
                        else
                        {
                            answer.Add(new Answer(s.Substring(0, s.Length), false));
                        }
                        break;
                    case 4:

                        if (s[0] == '1')
                        {
                            answer.Add(new Answer(s.Substring(1, s.Length - 1), true));
                        }
                        else
                        {
                            answer.Add(new Answer(s.Substring(0, s.Length), false));
                        }
                        break;
                    case 5:
                        if (s[0] == '1')
                        {
                            answer.Add(new Answer(s.Substring(1, s.Length - 1), true));
                        }
                        else
                        {
                            answer.Add(new Answer(s.Substring(0, s.Length), false));
                        }
                        break;
                    case 0:
                        if (s[0] == '1')
                        {
                            answer.Add(new Answer(s.Substring(1, s.Length - 1), true));
                        }
                        else
                        {
                            answer.Add(new Answer(s.Substring(0, s.Length), false));
                        }
                        Firstlist.Add(new Question(text, price, answer));
                        answer = new List<Answer>();
                        break;
                }

            }
            questionsTheme1 = Firstlist.ToArray();
            f.Close();
        }
        static void ParseSecond()
        {
            List<Question> Firstlist = new List<Question>();
            StreamReader f = new StreamReader("second.txt");
            int k = 0;
            string text = "";
            int price = 0;
            List<Answer> answer = new List<Answer>();
            while (!f.EndOfStream)
            {
                k++;
                string s = f.ReadLine();
                switch (k % 6)
                {
                    case 1:
                        text = s;
                        break;
                    case 2:
                        price = int.Parse(s);
                        break;
                    case 3:
                        if (s[0] == '1')
                        {
                            answer.Add(new Answer(s.Substring(1, s.Length - 1), true));
                        }
                        else
                        {
                            answer.Add(new Answer(s.Substring(0, s.Length), false));
                        }
                        break;
                    case 4:

                        if (s[0] == '1')
                        {
                            answer.Add(new Answer(s.Substring(1, s.Length - 1), true));
                        }
                        else
                        {
                            answer.Add(new Answer(s.Substring(0, s.Length), false));
                        }
                        break;
                    case 5:
                        if (s[0] == '1')
                        {
                            answer.Add(new Answer(s.Substring(1, s.Length - 1), true));
                        }
                        else
                        {
                            answer.Add(new Answer(s.Substring(0, s.Length), false));
                        }
                        break;
                    case 0:
                        if (s[0] == '1')
                        {
                            answer.Add(new Answer(s.Substring(1, s.Length - 1), true));
                        }
                        else
                        {
                            answer.Add(new Answer(s.Substring(0, s.Length), false));
                        }
                        Firstlist.Add(new Question(text, price, answer));
                        answer = new List<Answer>();
                        break;
                }

            }
            questionsTheme2 = Firstlist.ToArray();
            f.Close();
        }
        static void ParseThird()
        {
            List<Question> Firstlist = new List<Question>();
            StreamReader f = new StreamReader("third.txt");
            int k = 0;
            string text = "";
            int price = 0;
            List<Answer> answer = new List<Answer>();
            while (!f.EndOfStream)
            {
                k++;
                string s = f.ReadLine();
                switch (k % 6)
                {
                    case 1:
                        text = s;
                        break;
                    case 2:
                        price = int.Parse(s);
                        break;
                    case 3:
                        if (s[0] == '1')
                        {
                            answer.Add(new Answer(s.Substring(1, s.Length - 1), true));
                        }
                        else
                        {
                            answer.Add(new Answer(s.Substring(0, s.Length), false));
                        }
                        break;
                    case 4:

                        if (s[0] == '1')
                        {
                            answer.Add(new Answer(s.Substring(1, s.Length - 1), true));
                        }
                        else
                        {
                            answer.Add(new Answer(s.Substring(0, s.Length), false));
                        }
                        break;
                    case 5:
                        if (s[0] == '1')
                        {
                            answer.Add(new Answer(s.Substring(1, s.Length - 1), true));
                        }
                        else
                        {
                            answer.Add(new Answer(s.Substring(0, s.Length), false));
                        }
                        break;
                    case 0:
                        if (s[0] == '1')
                        {
                            answer.Add(new Answer(s.Substring(1, s.Length - 1), true));
                        }
                        else
                        {
                            answer.Add(new Answer(s.Substring(0, s.Length), false));
                        }
                        Firstlist.Add(new Question(text, price, answer));
                        answer = new List<Answer>();
                        break;
                }

            }
            questionsTheme3 = Firstlist.ToArray();
            f.Close();
        }
        static void ParseFourth()
        {
            List<Question> Firstlist = new List<Question>();
            StreamReader f = new StreamReader("fourth.txt");
            int k = 0;
            string text = "";
            int price = 0;
            List<Answer> answer = new List<Answer>();
            while (!f.EndOfStream)
            {
                k++;
                string s = f.ReadLine();
                switch (k % 6)
                {
                    case 1:
                        text = s;
                        break;
                    case 2:
                        price = int.Parse(s);
                        break;
                    case 3:
                        if (s[0] == '1')
                        {
                            answer.Add(new Answer(s.Substring(1, s.Length - 1), true));
                        }
                        else
                        {
                            answer.Add(new Answer(s.Substring(0, s.Length), false));
                        }
                        break;
                    case 4:

                        if (s[0] == '1')
                        {
                            answer.Add(new Answer(s.Substring(1, s.Length - 1), true));
                        }
                        else
                        {
                            answer.Add(new Answer(s.Substring(0, s.Length), false));
                        }
                        break;
                    case 5:
                        if (s[0] == '1')
                        {
                            answer.Add(new Answer(s.Substring(1, s.Length - 1), true));
                        }
                        else
                        {
                            answer.Add(new Answer(s.Substring(0, s.Length), false));
                        }
                        break;
                    case 0:
                        if (s[0] == '1')
                        {
                            answer.Add(new Answer(s.Substring(1, s.Length - 1), true));
                        }
                        else
                        {
                            answer.Add(new Answer(s.Substring(0, s.Length), false));
                        }
                        Firstlist.Add(new Question(text, price, answer));
                        answer = new List<Answer>();
                        break;
                }

            }
            questionsTheme4 = Firstlist.ToArray();
            f.Close();
        }


        public static Question GetQuestionTheme1()
        {
            Random rnd = new Random();
            i = rnd.Next(0, questionsTheme1.Length);
            while (questionsTheme1[i] == null)
            {
                i = rnd.Next(0, questionsTheme1.Length);
            }
            var res = questionsTheme1[i];
            questionsTheme1[i] = null;
            return res;
        }
        public static Question GetQuestionTheme2()
        {
            Random rnd = new Random();
            i = rnd.Next(0, questionsTheme2.Length);
            while (questionsTheme2[i] == null)
            {
                i = rnd.Next(0, questionsTheme2.Length);
            }
            var res = questionsTheme2[i];
            questionsTheme2[i] = null;
            return res;
        }
        public static Question GetQuestionTheme3()
        {
            Random rnd = new Random();
            i = rnd.Next(0, questionsTheme3.Length);
            while (questionsTheme3[i] == null)
            {
                i = rnd.Next(0, questionsTheme3.Length);
            }
            var res = questionsTheme3[i];
            questionsTheme3[i]=null;
            return res;
        }
        public static Question GetQuestionTheme4()
        {
            Random rnd = new Random();
            i = rnd.Next(0, questionsTheme4.Length);
            while (questionsTheme4[i] == null)
            {
                i = rnd.Next(0, questionsTheme4.Length);
            }
            var res = questionsTheme4[i];
            questionsTheme4[i] = null;
            return res;
        }
    }
}
