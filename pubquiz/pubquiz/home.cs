using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace pubquiz
{
    public partial class home : Form {
        public MySqlConnection mySqlConnection;
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        int ID = 0;
        public static int quizId;

        MySqlConnection con = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=pubquiz;Uid=root;Pwd=;");

        public home()
        {
            InitializeComponent();
            DisplayData();
        }


        // insert the new quizname into the database
        private void opslaanBtn_Click(object sender, EventArgs e)
        {
            if (txbNewQuiz.Text != "")
            {
                cmd = new MySqlCommand("INSERT INTO quizname(QuizName) VALUES(@name)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", txbNewQuiz.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("U heeft nog geen naam opgegeven!");
            }
        }

        // show the lasted data from the database
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("SELECT * FROM quizname", con);
            adapt.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();
        }

        // cleared the textbox
        private void ClearData()
        {
            txbNewQuiz.Text = "";
            btnQuestions.Enabled = false;
            btnPlayQuiz.Enabled = false;
            updateBtn.Enabled = false;
            deleteBtn.Enabled = false;
        }

        // delete the quiz
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (ID != 0){
                cmd = new MySqlCommand("DELETE FROM quizname WHERE quiz_id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Quiz is succesvol verwijderd!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("De quiz is niet verwijderd probeer het nog eens!!");
            }
        }

        // Updaten van de naam van de quiz
        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (txbNewQuiz.Text != "")
            {
                cmd = new MySqlCommand("UPDATE quizname SET quizName=@name WHERE quiz_id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", txbNewQuiz.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("De quiz is niet aangepast, probeer het nog eens!");
            }
        }

        // rowheadermouseclick event
        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnQuestions.Enabled = true;
            btnPlayQuiz.Enabled = true;
            updateBtn.Enabled = true;
            deleteBtn.Enabled = true;
            ID = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            txbNewQuiz.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            quizId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnQuestions_Click(object sender, EventArgs e)
        {
            if (quizId > 0)
            {
                this.Hide();
                questions questions = new questions(quizId);
                questions.ShowDialog();
            }
            else
            {
                MessageBox.Show("U heeft nog geen quiz geselecteerd!");
            }
        }

        private void home_Load(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnPlayQuiz_Click(object sender, EventArgs e)
        {
            if (quizId > 0)
            {
                this.Hide();
                playQuiz playQuiz = new playQuiz(quizId);
                playQuiz.Show();
            }
            else
            {
                MessageBox.Show("U heeft nog geen quiz geselecteerd!");
            }
        }
    }
}
