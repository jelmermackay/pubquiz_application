using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pubquiz
{
    struct Question
    {
        public int questionId { get; set; }
        public string question { get; set; }
        public int quizId { get; set; }
        public List<Awnser> awnsers { get; set; }
    }

    struct Awnser
    {
        public int awnserId { get; set; }
        public int questionId { get; set; }
        public bool trueFalse { get; set; }
        public string awnser { get; set; }
    }

    public partial class playQuiz : Form
    {
        public MySqlConnection mySqlConnection;
        public MySqlDataAdapter adapt;
        public MySqlDataAdapter adapt2;
        public int quizId;
        public int counter = 0;
        public int counterAwnser = 0;
        //public Timer countdownTimer;

        List<Question> arrayQuestions;

        MySqlConnection con = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=pubquiz;Uid=root;Pwd=;");

        public playQuiz(int quizId)
        {
            this.quizId = quizId;
            InitializeComponent();
        }

        private void playQuiz_Load(object sender, EventArgs e)
        {
            arrayQuestions = new List<Question>();
            con.Open();
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM question WHERE quiz_id = " + quizId + "";
            adapt = new MySqlDataAdapter(sql.ToString(), con);
            adapt.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Question question = new Question();
                question.question = row["question"].ToString();
                question.questionId = int.Parse(row["question_id"].ToString());
                question.quizId = int.Parse(row["quiz_id"].ToString());
                question.awnsers = new List<Awnser>();

                DataTable dt2 = new DataTable();
                string sql2 = "SELECT * FROM awnser WHERE question_id = " + question.questionId;
                adapt2 = new MySqlDataAdapter(sql2.ToString(), con);
                adapt2.Fill(dt2);
                foreach (DataRow row2 in dt2.Rows)
                {
                    Awnser awnser = new Awnser();
                    awnser.awnser = row2["awnser"].ToString();
                    awnser.awnserId = int.Parse(row2["awnser_id"].ToString());
                    awnser.questionId = int.Parse(row2["question_id"].ToString());
                    awnser.trueFalse = bool.Parse(row2["trueFalse"].ToString());
                    question.awnsers.Add(awnser);
                }
                arrayQuestions.Add(question);
            }
            con.Close();
            showNewQuestion();
        }

        public void showNewQuestion()
        {
            if (arrayQuestions.Count > counter)
            {
                if (arrayQuestions[counter].awnsers.Count != 4)
                {
                    counter++;
                    anotherQuestion();
                } else
                {
                    //setTimer();
                    lblQuestion.Text = "Vraag: " + arrayQuestions[counter].question;
                    lblAwnser1.Text = "Antwoord A: \r" + arrayQuestions[counter].awnsers[0].awnser;
                    lblAwnser2.Text = "Antwoord B: \r" + arrayQuestions[counter].awnsers[1].awnser;
                    lblAwnser3.Text = "Antwoord C: \r" + arrayQuestions[counter].awnsers[2].awnser;
                    lblAwnser4.Text = "Antwoord D: \r" + arrayQuestions[counter].awnsers[3].awnser;
                    counter++;
                }
            } else if (arrayQuestions.Count + 1 >= counterAwnser)
            {
                if (arrayQuestions.Count == counterAwnser)
                {
                    this.Hide();
                    home home = new home();
                    home.ShowDialog();
                }
                else {
                    lblQuestion.Text = "Vraag: " + arrayQuestions[counterAwnser].question;
                    if (arrayQuestions[counterAwnser].awnsers[0].trueFalse == true)
                    {
                        lblBackgroundWhite();
                        this.lblAwnser1.BackColor = System.Drawing.Color.LimeGreen;
                    } else if (arrayQuestions[counterAwnser].awnsers[1].trueFalse == true)
                    {
                        lblBackgroundWhite();
                        this.lblAwnser2.BackColor = System.Drawing.Color.LimeGreen;
                    } else if (arrayQuestions[counterAwnser].awnsers[2].trueFalse == true)
                    {
                        lblBackgroundWhite();
                        this.lblAwnser3.BackColor = System.Drawing.Color.LimeGreen;
                    } else if (arrayQuestions[counterAwnser].awnsers[3].trueFalse == true)
                    {
                        lblBackgroundWhite();
                        this.lblAwnser4.BackColor = System.Drawing.Color.LimeGreen;
                    }
                    if (arrayQuestions[counterAwnser].awnsers.Count != 4)
                    {
                        counterAwnser++;
                        anotherQuestion();
                    }
                    else
                    {
                        lblAwnser1.Text = "Antwoord A: \r" + arrayQuestions[counterAwnser].awnsers[0].awnser;
                        lblAwnser2.Text = "Antwoord B: \r" + arrayQuestions[counterAwnser].awnsers[1].awnser;
                        lblAwnser3.Text = "Antwoord C: \r" + arrayQuestions[counterAwnser].awnsers[2].awnser;
                        lblAwnser4.Text = "Antwoord D: \r" + arrayQuestions[counterAwnser].awnsers[3].awnser;
                        counterAwnser++;
                    }

                }
            }
        }


        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            showNewQuestion();
        }

        public void lblBackgroundWhite()
        {
            this.lblAwnser1.BackColor = System.Drawing.Color.White; 
            this.lblAwnser2.BackColor = System.Drawing.Color.White;
            this.lblAwnser3.BackColor = System.Drawing.Color.White;
            this.lblAwnser4.BackColor = System.Drawing.Color.White;
        }
        public void anotherQuestion() {
            showNewQuestion();
        }
    }
}