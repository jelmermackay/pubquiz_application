namespace pubquiz
{
    partial class addAwnser
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
            this.txbAwnser = new System.Windows.Forms.TextBox();
            this.btnSaveAwnser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.goToQuestion = new System.Windows.Forms.Button();
            this.btnUpdateAwnser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoToHome = new System.Windows.Forms.Button();
            this.btnDeleteAwnser = new System.Windows.Forms.Button();
            this.cbGoodAwnser = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbAwnser
            // 
            this.txbAwnser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAwnser.Location = new System.Drawing.Point(28, 50);
            this.txbAwnser.Name = "txbAwnser";
            this.txbAwnser.Size = new System.Drawing.Size(148, 27);
            this.txbAwnser.TabIndex = 0;
            // 
            // btnSaveAwnser
            // 
            this.btnSaveAwnser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAwnser.Location = new System.Drawing.Point(28, 130);
            this.btnSaveAwnser.Name = "btnSaveAwnser";
            this.btnSaveAwnser.Size = new System.Drawing.Size(148, 30);
            this.btnSaveAwnser.TabIndex = 4;
            this.btnSaveAwnser.Text = "Opslaan";
            this.btnSaveAwnser.UseVisualStyleBackColor = true;
            this.btnSaveAwnser.Click += new System.EventHandler(this.btnSaveAwnser_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(210, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(591, 350);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // goToQuestion
            // 
            this.goToQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToQuestion.Location = new System.Drawing.Point(28, 272);
            this.goToQuestion.Name = "goToQuestion";
            this.goToQuestion.Size = new System.Drawing.Size(148, 30);
            this.goToQuestion.TabIndex = 6;
            this.goToQuestion.Text = "Vragen";
            this.goToQuestion.UseVisualStyleBackColor = true;
            this.goToQuestion.Click += new System.EventHandler(this.goToQuestion_Click);
            // 
            // btnUpdateAwnser
            // 
            this.btnUpdateAwnser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAwnser.Location = new System.Drawing.Point(28, 166);
            this.btnUpdateAwnser.Name = "btnUpdateAwnser";
            this.btnUpdateAwnser.Size = new System.Drawing.Size(148, 30);
            this.btnUpdateAwnser.TabIndex = 7;
            this.btnUpdateAwnser.Text = "Update";
            this.btnUpdateAwnser.UseVisualStyleBackColor = true;
            this.btnUpdateAwnser.Click += new System.EventHandler(this.btnUpdateAwnser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nieuw antwoord toevoegen";
            // 
            // btnGoToHome
            // 
            this.btnGoToHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToHome.Location = new System.Drawing.Point(28, 308);
            this.btnGoToHome.Name = "btnGoToHome";
            this.btnGoToHome.Size = new System.Drawing.Size(148, 30);
            this.btnGoToHome.TabIndex = 12;
            this.btnGoToHome.Text = "Home";
            this.btnGoToHome.UseVisualStyleBackColor = true;
            this.btnGoToHome.Click += new System.EventHandler(this.btnGoToHome_Click);
            // 
            // btnDeleteAwnser
            // 
            this.btnDeleteAwnser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAwnser.Location = new System.Drawing.Point(28, 202);
            this.btnDeleteAwnser.Name = "btnDeleteAwnser";
            this.btnDeleteAwnser.Size = new System.Drawing.Size(148, 30);
            this.btnDeleteAwnser.TabIndex = 14;
            this.btnDeleteAwnser.Text = "Delete";
            this.btnDeleteAwnser.UseVisualStyleBackColor = true;
            this.btnDeleteAwnser.Click += new System.EventHandler(this.btnDeleteAwnser_Click);
            // 
            // cbGoodAwnser
            // 
            this.cbGoodAwnser.AutoSize = true;
            this.cbGoodAwnser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGoodAwnser.Location = new System.Drawing.Point(28, 93);
            this.cbGoodAwnser.Name = "cbGoodAwnser";
            this.cbGoodAwnser.Size = new System.Drawing.Size(151, 22);
            this.cbGoodAwnser.TabIndex = 15;
            this.cbGoodAwnser.Text = "goede antwoord";
            this.cbGoodAwnser.UseVisualStyleBackColor = true;
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
            this.label2.TabIndex = 16;
            this.label2.Text = "QuizTime";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbAwnser);
            this.panel1.Controls.Add(this.cbGoodAwnser);
            this.panel1.Controls.Add(this.btnUpdateAwnser);
            this.panel1.Controls.Add(this.btnGoToHome);
            this.panel1.Controls.Add(this.btnDeleteAwnser);
            this.panel1.Controls.Add(this.goToQuestion);
            this.panel1.Controls.Add(this.btnSaveAwnser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 350);
            this.panel1.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(219, 415);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(581, 35);
            this.panel5.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(765, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(35, 315);
            this.panel3.TabIndex = 19;
            // 
            // addAwnser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "addAwnser";
            this.Text = "addAwnser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbAwnser;
        private System.Windows.Forms.Button btnSaveAwnser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button goToQuestion;
        private System.Windows.Forms.Button btnUpdateAwnser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoToHome;
        private System.Windows.Forms.Button btnDeleteAwnser;
        private System.Windows.Forms.CheckBox cbGoodAwnser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
    }
}