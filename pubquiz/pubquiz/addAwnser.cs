using MySql.Data.MySqlClient;
using System;
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
    public partial class addAwnser : Form
    {
        public MySqlConnection mySqlConnection;
        MySqlCommand cmd;
        MySqlDataAdapter adaptAwnser;
        int awnserId = 0;
        public int questionId;
        public int quizId;

        MySqlConnection con = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=pubquiz;Uid=root;Pwd=;");

        public addAwnser(int questionId, int quizId)
        {
            this.questionId = questionId;
            this.quizId = quizId;
            InitializeComponent();
            DisplayData();

            btnDeleteAwnser.Enabled = false;
            btnUpdateAwnser.Enabled = false;
        }

        private void btnSaveAwnser_Click(object sender, EventArgs e)
        {
            if (txbAwnser.Text != "")
            {
                cmd = new MySqlCommand("INSERT INTO awnser(awnser, question_id, trueFalse) VALUES(@txbAwnser, @questionId, @trueFalse)", con);
                con.Open();
                if (cbGoodAwnser.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@trueFalse", true);
                }
                else 
                {
                    cmd.Parameters.AddWithValue("@trueFalse", false);
                }
                cmd.Parameters.AddWithValue("@txbAwnser", txbAwnser.Text);
                cmd.Parameters.AddWithValue("@questionId", questionId);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("U heeft nog niet alle antwoorden ingevuld!");
            }
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM awnser WHERE question_id = " + questionId + "";
            adaptAwnser = new MySqlDataAdapter(sql.ToString(), con);
            adaptAwnser.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            if (dt.Rows.Count > 3)
            {
                btnSaveAwnser.Enabled = false;
            }
        }

        private void ClearData()
        {
            txbAwnser.Text = "";
            cbGoodAwnser.Checked = false;
        }

        private void goToQuestion_Click(object sender, EventArgs e)
        {
            this.Hide();
            questions questions = new questions(quizId);
            questions.ShowDialog();
        }

        private void btnUpdateAwnser_Click(object sender, EventArgs e)
        {
            if (txbAwnser.Text != "")
            {
                cmd = new MySqlCommand("UPDATE awnser SET awnser=@newAwnser, trueFalse=@boolean WHERE awnser_id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", awnserId);
                cmd.Parameters.AddWithValue("@newAwnser", txbAwnser.Text);
                cmd.Parameters.AddWithValue("@boolean", cbGoodAwnser.Checked);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                ClearData();
            }
        }

        private void btnGoToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            home home = new home();
            home.ShowDialog();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnDeleteAwnser.Enabled = true;
            btnUpdateAwnser.Enabled = true;
            awnserId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txbAwnser.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbGoodAwnser.Checked = bool.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void btnDeleteAwnser_Click(object sender, EventArgs e)
        {
            if (awnserId != 0)
            {
                cmd = new MySqlCommand("DELETE FROM awnser WHERE awnser_id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", awnserId);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                ClearData();
                btnSaveAwnser.Enabled = true;
            }
            else
            {
                MessageBox.Show("Het antwoord is niet verwijderd probeer het nog eens!!");
            }
        }
    }
}
