namespace pubquiz
{
    partial class questions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbQuestion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.goToHomeScreen = new System.Windows.Forms.Button();
            this.btnSaveQuestion = new System.Windows.Forms.Button();
            this.btnAddAwnsers = new System.Windows.Forms.Button();
            this.btnUpdateQuestion = new System.Windows.Forms.Button();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(215, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(589, 350);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(800, 100);
            this.label2.TabIndex = 13;
            this.label2.Text = "QuizTime";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbQuestion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.goToHomeScreen);
            this.panel1.Controls.Add(this.btnSaveQuestion);
            this.panel1.Controls.Add(this.btnAddAwnsers);
            this.panel1.Controls.Add(this.btnUpdateQuestion);
            this.panel1.Controls.Add(this.btnDeleteQuestion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 350);
            this.panel1.TabIndex = 15;
            // 
            // txbQuestion
            // 
            this.txbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuestion.Location = new System.Drawing.Point(28, 50);
            this.txbQuestion.Name = "txbQuestion";
            this.txbQuestion.Size = new System.Drawing.Size(148, 27);
            this.txbQuestion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nieuwe vraag toevoegen";
            // 
            // goToHomeScreen
            // 
            this.goToHomeScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToHomeScreen.Location = new System.Drawing.Point(28, 309);
            this.goToHomeScreen.Name = "goToHomeScreen";
            this.goToHomeScreen.Size = new System.Drawing.Size(148, 30);
            this.goToHomeScreen.TabIndex = 7;
            this.goToHomeScreen.Text = "Home";
            this.goToHomeScreen.UseVisualStyleBackColor = true;
            this.goToHomeScreen.Click += new System.EventHandler(this.goToHomeScreen_Click);
            // 
            // btnSaveQuestion
            // 
            this.btnSaveQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveQuestion.Location = new System.Drawing.Point(28, 103);
            this.btnSaveQuestion.Name = "btnSaveQuestion";
            this.btnSaveQuestion.Size = new System.Drawing.Size(148, 30);
            this.btnSaveQuestion.TabIndex = 3;
            this.btnSaveQuestion.Text = "Opslaan";
            this.btnSaveQuestion.UseVisualStyleBackColor = true;
            this.btnSaveQuestion.Click += new System.EventHandler(this.btnSaveQuestion_Click);
            // 
            // btnAddAwnsers
            // 
            this.btnAddAwnsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAwnsers.Location = new System.Drawing.Point(28, 273);
            this.btnAddAwnsers.Name = "btnAddAwnsers";
            this.btnAddAwnsers.Size = new System.Drawing.Size(148, 30);
            this.btnAddAwnsers.TabIndex = 6;
            this.btnAddAwnsers.Text = "Antwoorden\r\n";
            this.btnAddAwnsers.UseVisualStyleBackColor = true;
            this.btnAddAwnsers.Click += new System.EventHandler(this.btnAddAwnsers_Click);
            // 
            // btnUpdateQuestion
            // 
            this.btnUpdateQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateQuestion.Location = new System.Drawing.Point(28, 139);
            this.btnUpdateQuestion.Name = "btnUpdateQuestion";
            this.btnUpdateQuestion.Size = new System.Drawing.Size(148, 30);
            this.btnUpdateQuestion.TabIndex = 4;
            this.btnUpdateQuestion.Text = "Update";
            this.btnUpdateQuestion.UseVisualStyleBackColor = true;
            this.btnUpdateQuestion.Click += new System.EventHandler(this.btnUpdateQuestion_Click);
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteQuestion.Location = new System.Drawing.Point(28, 175);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(148, 30);
            this.btnDeleteQuestion.TabIndex = 5;
            this.btnDeleteQuestion.Text = "Delete";
            this.btnDeleteQuestion.UseVisualStyleBackColor = true;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(219, 415);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(581, 35);
            this.panel5.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(765, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(35, 315);
            this.panel3.TabIndex = 17;
            // 
            // questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "questions";
            this.Text = "questions";
            this.Load += new System.EventHandler(this.questions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goToHomeScreen;
        private System.Windows.Forms.Button btnSaveQuestion;
        private System.Windows.Forms.Button btnAddAwnsers;
        private System.Windows.Forms.Button btnUpdateQuestion;
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
    }
}