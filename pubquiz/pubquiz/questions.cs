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
    public partial class questions : Form
    {
        public MySqlConnection mySqlConnection;
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        int ID = 0;
        public int quizId;
        public int antwoordId;

        MySqlConnection con = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=pubquiz;Uid=root;Pwd=;");

        public questions(int quizId)
        {
            this.quizId = quizId;
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM question WHERE quiz_id = " + quizId + "";
            adapt = new MySqlDataAdapter(sql.ToString(), con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        // cleared the textbox
        private void ClearData()
        {
            txbQuestion.Text = "";
        }

        private void btnSaveQuestion_Click(object sender, EventArgs e)
        {
            if (txbQuestion.Text != "")
            {
                cmd = new MySqlCommand("INSERT INTO question(question, quiz_id) VALUES(@txbQuestion, @quizId)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@txbQuestion", txbQuestion.Text);
                cmd.Parameters.AddWithValue("@quizId", quizId);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("U heeft nog geen vraag ingevuld!");
            }
        }

        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            if (txbQuestion.Text != "")
            {
                cmd = new MySqlCommand("UPDATE question SET question=@newQuestion WHERE question_id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@newQuestion", txbQuestion.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("De vraag is niet aangepast, u heeft nog nix ingevuld!");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAddAwnsers.Enabled = true;
            btnDeleteQuestion.Enabled = true;
            btnUpdateQuestion.Enabled = true;
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txbQuestion.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            antwoordId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new MySqlCommand("DELETE FROM question WHERE question_id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("De vraag is succesvol verwijderd!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("De vraag is niet verwijderd probeer het nog eens!!");
            }
        }

        private void btnAddAwnsers_Click(object sender, EventArgs e)
        {
            if (antwoordId > 0)
            {
                this.Hide();
                addAwnser awnser = new addAwnser(antwoordId, quizId);
                awnser.ShowDialog();
            }
            else
            {
                MessageBox.Show("U heeft nog geen vraag gesellecteerd!");
            }
        }

        private void questions_Load(object sender, EventArgs e)
        {
            btnAddAwnsers.Enabled = false;
            btnDeleteQuestion.Enabled = false;
            btnUpdateQuestion.Enabled = false;
        }

        private void goToHomeScreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            home home = new home();
            home.ShowDialog();
        }
    }
}
