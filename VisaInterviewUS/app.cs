using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SpeechLib;

namespace VisaInterviewUS
{
    public partial class app : Form
    {
        public static class Question
        {
            static public string[] Questions = {
                "What do you want to do in future / after you graduate? What are your plans for future?",
                "What is Data Science?",
                "Why Data Science?",
                "What do you want after work and travel?",
                "Why do want to work in America/USA/United States? Why do you want to join/participate in this program? Why do you want to attend this program? Why do you want to be a participant of this program?",
                "What department are you going to work at? / What jobs will you do? What job are you going to do?",
                "Do you have experience as a Counter Helper?",
                "What does a Counter Helper do?",
                "When will you go/when will you arrive in the USA? When do you plan to travel / arrive in the USA?",
                "When does your school close?",
                "When does your school open?",
                "How long will you stay in America?",
                "What dates are you going to work in America?",
                "Do you know the details about your job?",
                "Did you read anti trafficking pamphlet, and did you understand it?",
                "What do you want to do in future? ",
                "Why do you want to work as a Counter Helper?",
                "Do you want to visit any cities in the USA?",
                "Where will you go in the USA? Where are you going to go in the USA? Where are you going to in America?",
                "How much money are you planning to take with you to the United States?",
                "Why do you want to spend your holiday duration in the USA by doing a hard job like this?",
                "If you do not have experience, how did you get the job?",
                "Tell me about your school?",
                "What is the Counter Help?",
                "What is Computer Science?",
                "Who is paying your university tuition?",
                "Do you get whole or partial scholarship?",
                "How much do you get in scholarship?",
                "Why U.S.?",
                "Why New Hampshire?",
                "Why are your scores decreasing?",
                "What did you do last summer?",
                "From where did you learn this program?",
                "What your family do?",
                "Why are your last term scores low?",
                "Why you left your job?",
                "What course did you choose last term?",
                "What did you learn in Computer Networks course?",
                "What did you learn in Philosophy course?",
                "What did you learn in Modeling of Layer Systems course?",
                "What did you learn in Numeric Methods course?",
                "What did you learn in Analysis and Preparation Methods of Algorithms course?",
                "What did you learn in Physics course?",
                "What did you learn in Applied Programs Packet course?",
                "What did you learn in Theory of Probability and Mathematical Statistics course?",
                "What did you learn in Discrete Mathematics course?",
                "What did you learn in Database course?",
                "What did you learn in History of Azerbaijan course?",
                "What did you learn in Operations Application and Games Theory course?",
                "What did you learn in “Formation Technology of Web Sites” course?",
                "What did you learn in Programming Technologies course?",
                "What did you learn in Foreign Language course?",
                "What did you learn in Differential Equations course?",
                "What did you learn in Mathematical Analysis course?",
                "What did you learn in Computer Architecture course?",
                "What did you learn in Principles of Programming course?",
                "What did you learn in Analytic Geometry course?",
                "What did you learn in Linear Algebra course?",
                "What did you learn in Azerbaijani Language and Culture of Speech course?",
            };
            static public string[] AskedQuestions = Questions;
            static private int _count = 0;

            static public int Count
            {
                get { return _count; }
                set { _count = value; }
            }

            static public string Play()
            {
                Random random = new Random();
                int rndm = random.Next(AskedQuestions.Length);

                string question = AskedQuestions[rndm];
                AskedQuestions = AskedQuestions.Where((source, index) => index != rndm).ToArray();
                Count++;

                return question;
            }

            static public void ChangeQuestions(string questionsPath)
            {
                Count = 0;
                Questions = System.IO.File.ReadAllLines(questionsPath);
                AskedQuestions = Questions;
            }

            static public void Restart()
            {
                Count = 0;
                AskedQuestions = Questions;
            }
        }
        public app()
        {
            InitializeComponent();
        }

        private void playbtn_Click(object sender, EventArgs e)
        {
            if (Question.AskedQuestions.Length == 0) return;
            if (Question.AskedQuestions.Length == 1) playbtn.Visible = false;
            
            questionlbl.Text = $"{Question.Count + 1}: {Question.Play()}";
            questionlbl.Refresh();

            SpVoice spvoice = new SpVoice();
            spvoice.Speak(questionlbl.Text.Substring(questionlbl.Text.IndexOf(" ") + 1));
        }

        private void addquestbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = System.IO.Directory.GetCurrentDirectory(),
                Title = "Add your questions",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true,
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Question.ChangeQuestions(openFileDialog.FileName);
            }
        }

        private void restartbtn_Click(object sender, EventArgs e)
        {
            Question.Restart();

            if (playbtn.Visible == false) playbtn.Visible = true;
        }
    }
}
