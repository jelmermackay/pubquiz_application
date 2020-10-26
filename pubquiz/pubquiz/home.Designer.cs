namespace pubquiz
{
    partial class home
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
            this.txbNewQuiz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.opslaanBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnQuestions = new System.Windows.Forms.Button();
            this.btnPlayQuiz = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbNewQuiz
            // 
            this.txbNewQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewQuiz.Location = new System.Drawing.Point(28, 52);
            this.txbNewQuiz.Name = "txbNewQuiz";
            this.txbNewQuiz.Size = new System.Drawing.Size(148, 27);
            this.txbNewQuiz.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nieuwe quiz toevoegen";
            // 
            // opslaanBtn
            // 
            this.opslaanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opslaanBtn.Location = new System.Drawing.Point(28, 99);
            this.opslaanBtn.Name = "opslaanBtn";
            this.opslaanBtn.Size = new System.Drawing.Size(148, 30);
            this.opslaanBtn.TabIndex = 2;
            this.opslaanBtn.Text = "Opslaan";
            this.opslaanBtn.UseVisualStyleBackColor = true;
            this.opslaanBtn.Click += new System.EventHandler(this.opslaanBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(28, 135);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(148, 30);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(28, 171);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(148, 30);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(-8, -8);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(587, 355);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_RowHeaderMouseClick);
            // 
            // btnQuestions
            // 
            this.btnQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestions.Location = new System.Drawing.Point(28, 272);
            this.btnQuestions.Name = "btnQuestions";
            this.btnQuestions.Size = new System.Drawing.Size(148, 30);
            this.btnQuestions.TabIndex = 6;
            this.btnQuestions.Text = "Vragen";
            this.btnQuestions.UseVisualStyleBackColor = true;
            this.btnQuestions.Click += new System.EventHandler(this.btnQuestions_Click);
            // 
            // btnPlayQuiz
            // 
            this.btnPlayQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayQuiz.Location = new System.Drawing.Point(28, 308);
            this.btnPlayQuiz.Name = "btnPlayQuiz";
            this.btnPlayQuiz.Size = new System.Drawing.Size(148, 30);
            this.btnPlayQuiz.TabIndex = 7;
            this.btnPlayQuiz.Text = "Quiz spelen";
            this.btnPlayQuiz.UseVisualStyleBackColor = true;
            this.btnPlayQuiz.Click += new System.EventHandler(this.btnPlayQuiz_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txbNewQuiz);
            this.panel2.Controls.Add(this.btnPlayQuiz);
            this.panel2.Controls.Add(this.opslaanBtn);
            this.panel2.Controls.Add(this.updateBtn);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.btnQuestions);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 350);
            this.panel2.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.dataGridView);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(235, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(565, 350);
            this.panel4.TabIndex = 11;
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
            this.label2.TabIndex = 0;
            this.label2.Text = "QuizTime";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(530, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(35, 350);
            this.panel3.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 315);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(530, 35);
            this.panel5.TabIndex = 8;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbNewQuiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button opslaanBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnQuestions;
        private System.Windows.Forms.Button btnPlayQuiz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
    }
}

