
namespace BlackJack
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HIT = new System.Windows.Forms.Button();
            this.STAND = new System.Windows.Forms.Button();
            this.RESET = new System.Windows.Forms.Button();
            this.Dealer_Score = new System.Windows.Forms.TextBox();
            this.Player_Score = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.START = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dealer Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player Score";
            // 
            // HIT
            // 
            this.HIT.Enabled = false;
            this.HIT.Location = new System.Drawing.Point(153, 244);
            this.HIT.Name = "HIT";
            this.HIT.Size = new System.Drawing.Size(75, 23);
            this.HIT.TabIndex = 2;
            this.HIT.Text = "HIT";
            this.HIT.UseVisualStyleBackColor = true;
            this.HIT.Click += new System.EventHandler(this.HIT_Click);
            // 
            // STAND
            // 
            this.STAND.Enabled = false;
            this.STAND.Location = new System.Drawing.Point(288, 244);
            this.STAND.Name = "STAND";
            this.STAND.Size = new System.Drawing.Size(75, 23);
            this.STAND.TabIndex = 3;
            this.STAND.Text = "STAND";
            this.STAND.UseVisualStyleBackColor = true;
            this.STAND.Click += new System.EventHandler(this.STAND_Click);
            // 
            // RESET
            // 
            this.RESET.Enabled = false;
            this.RESET.Location = new System.Drawing.Point(423, 243);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(75, 23);
            this.RESET.TabIndex = 4;
            this.RESET.Text = "RESET";
            this.RESET.UseVisualStyleBackColor = true;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // Dealer_Score
            // 
            this.Dealer_Score.Location = new System.Drawing.Point(278, 66);
            this.Dealer_Score.Name = "Dealer_Score";
            this.Dealer_Score.ReadOnly = true;
            this.Dealer_Score.Size = new System.Drawing.Size(100, 20);
            this.Dealer_Score.TabIndex = 5;
            this.Dealer_Score.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Player_Score
            // 
            this.Player_Score.Location = new System.Drawing.Point(278, 99);
            this.Player_Score.Name = "Player_Score";
            this.Player_Score.ReadOnly = true;
            this.Player_Score.Size = new System.Drawing.Size(100, 20);
            this.Player_Score.TabIndex = 6;
            this.Player_Score.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(305, 172);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 13);
            this.Result.TabIndex = 7;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // START
            // 
            this.START.Location = new System.Drawing.Point(278, 349);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(184, 30);
            this.START.TabIndex = 8;
            this.START.Text = "START";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 522);
            this.Controls.Add(this.START);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Player_Score);
            this.Controls.Add(this.Dealer_Score);
            this.Controls.Add(this.RESET);
            this.Controls.Add(this.STAND);
            this.Controls.Add(this.HIT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlackJack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button HIT;
        private System.Windows.Forms.Button STAND;
        private System.Windows.Forms.Button RESET;
        private System.Windows.Forms.TextBox Dealer_Score;
        private System.Windows.Forms.TextBox Player_Score;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button START;
    }
}

