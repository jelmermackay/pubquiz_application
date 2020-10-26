namespace pubquiz
{
    partial class playQuiz
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.lblAwnser1 = new System.Windows.Forms.Label();
            this.lblAwnser2 = new System.Windows.Forms.Label();
            this.lblAwnser3 = new System.Windows.Forms.Label();
            this.lblAwnser4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Navy;
            this.lblQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblQuestion.Location = new System.Drawing.Point(0, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(733, 55);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Vraag: ";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQuestion.Location = new System.Drawing.Point(0, 391);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(733, 46);
            this.btnNextQuestion.TabIndex = 1;
            this.btnNextQuestion.Text = "Volgende";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // lblAwnser1
            // 
            this.lblAwnser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAwnser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAwnser1.Location = new System.Drawing.Point(3, 0);
            this.lblAwnser1.Name = "lblAwnser1";
            this.lblAwnser1.Size = new System.Drawing.Size(360, 145);
            this.lblAwnser1.TabIndex = 2;
            this.lblAwnser1.Text = "Antwoord A:";
            this.lblAwnser1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAwnser2
            // 
            this.lblAwnser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAwnser2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAwnser2.Location = new System.Drawing.Point(3, 145);
            this.lblAwnser2.Name = "lblAwnser2";
            this.lblAwnser2.Size = new System.Drawing.Size(360, 146);
            this.lblAwnser2.TabIndex = 3;
            this.lblAwnser2.Text = "Antwoord B:";
            this.lblAwnser2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAwnser3
            // 
            this.lblAwnser3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAwnser3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAwnser3.Location = new System.Drawing.Point(369, 0);
            this.lblAwnser3.Name = "lblAwnser3";
            this.lblAwnser3.Size = new System.Drawing.Size(361, 145);
            this.lblAwnser3.TabIndex = 4;
            this.lblAwnser3.Text = "Antwoord C:";
            this.lblAwnser3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAwnser4
            // 
            this.lblAwnser4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAwnser4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAwnser4.Location = new System.Drawing.Point(369, 145);
            this.lblAwnser4.Name = "lblAwnser4";
            this.lblAwnser4.Size = new System.Drawing.Size(361, 146);
            this.lblAwnser4.TabIndex = 5;
            this.lblAwnser4.Text = "Antwoord D: ";
            this.lblAwnser4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.lblQuestion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 100);
            this.panel1.TabIndex = 6;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Navy;
            this.lblTimer.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTimer.Location = new System.Drawing.Point(733, 55);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 44);
            this.lblTimer.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblAwnser3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAwnser4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAwnser1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAwnser2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(733, 291);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // playQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 437);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.panel1);
            this.Name = "playQuiz";
            this.Text = "playQuiz";
            this.Load += new System.EventHandler(this.playQuiz_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Label lblAwnser1;
        private System.Windows.Forms.Label lblAwnser2;
        private System.Windows.Forms.Label lblAwnser3;
        private System.Windows.Forms.Label lblAwnser4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTimer;
    }
}