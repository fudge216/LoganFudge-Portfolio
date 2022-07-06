
namespace Jeopardy_final
{
    partial class QandA_Form
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
            this.lb_pts = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Answer = new System.Windows.Forms.RichTextBox();
            this.tb_Question = new System.Windows.Forms.RichTextBox();
            this.btt_Submit = new System.Windows.Forms.Button();
            this.cb_correct_answer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btt_next_Q = new System.Windows.Forms.Button();
            this.Gb_Players = new System.Windows.Forms.GroupBox();
            this.rb_P3_Selected = new System.Windows.Forms.RadioButton();
            this.rb_P2_Selected = new System.Windows.Forms.RadioButton();
            this.rb_P1_Selected = new System.Windows.Forms.RadioButton();
            this.gb_P3 = new System.Windows.Forms.GroupBox();
            this.lb_P3_pts = new System.Windows.Forms.Label();
            this.gb_P2 = new System.Windows.Forms.GroupBox();
            this.lb_P2_pts = new System.Windows.Forms.Label();
            this.gb_P1 = new System.Windows.Forms.GroupBox();
            this.lb_P1_pts = new System.Windows.Forms.Label();
            this.Gb_Players.SuspendLayout();
            this.gb_P3.SuspendLayout();
            this.gb_P2.SuspendLayout();
            this.gb_P1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Violet;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(36, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question:";
            // 
            // lb_pts
            // 
            this.lb_pts.AutoSize = true;
            this.lb_pts.BackColor = System.Drawing.Color.Violet;
            this.lb_pts.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pts.ForeColor = System.Drawing.Color.Indigo;
            this.lb_pts.Location = new System.Drawing.Point(297, 29);
            this.lb_pts.Name = "lb_pts";
            this.lb_pts.Size = new System.Drawing.Size(44, 24);
            this.lb_pts.TabIndex = 2;
            this.lb_pts.Text = "pts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Violet;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(36, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Answer:";
            // 
            // tb_Answer
            // 
            this.tb_Answer.Location = new System.Drawing.Point(32, 56);
            this.tb_Answer.Name = "tb_Answer";
            this.tb_Answer.Size = new System.Drawing.Size(173, 27);
            this.tb_Answer.TabIndex = 5;
            this.tb_Answer.Text = "";
            // 
            // tb_Question
            // 
            this.tb_Question.Location = new System.Drawing.Point(32, 144);
            this.tb_Question.Name = "tb_Question";
            this.tb_Question.Size = new System.Drawing.Size(322, 91);
            this.tb_Question.TabIndex = 6;
            this.tb_Question.Text = "";
            // 
            // btt_Submit
            // 
            this.btt_Submit.Location = new System.Drawing.Point(32, 241);
            this.btt_Submit.Name = "btt_Submit";
            this.btt_Submit.Size = new System.Drawing.Size(133, 36);
            this.btt_Submit.TabIndex = 7;
            this.btt_Submit.Text = "Submit";
            this.btt_Submit.UseVisualStyleBackColor = true;
            this.btt_Submit.Click += new System.EventHandler(this.btt_Submit_Click);
            // 
            // cb_correct_answer
            // 
            this.cb_correct_answer.FormattingEnabled = true;
            this.cb_correct_answer.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cb_correct_answer.Location = new System.Drawing.Point(28, 324);
            this.cb_correct_answer.Name = "cb_correct_answer";
            this.cb_correct_answer.Size = new System.Drawing.Size(121, 21);
            this.cb_correct_answer.TabIndex = 31;
            this.cb_correct_answer.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Violet;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(28, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Was player correct?";
            this.label6.Visible = false;
            // 
            // btt_next_Q
            // 
            this.btt_next_Q.Location = new System.Drawing.Point(270, 324);
            this.btt_next_Q.Name = "btt_next_Q";
            this.btt_next_Q.Size = new System.Drawing.Size(108, 29);
            this.btt_next_Q.TabIndex = 32;
            this.btt_next_Q.Text = "Submit";
            this.btt_next_Q.UseVisualStyleBackColor = true;
            this.btt_next_Q.Click += new System.EventHandler(this.btt_next_Q_Click);
            // 
            // Gb_Players
            // 
            this.Gb_Players.BackColor = System.Drawing.Color.MediumPurple;
            this.Gb_Players.Controls.Add(this.rb_P3_Selected);
            this.Gb_Players.Controls.Add(this.rb_P2_Selected);
            this.Gb_Players.Controls.Add(this.rb_P1_Selected);
            this.Gb_Players.Controls.Add(this.gb_P3);
            this.Gb_Players.Controls.Add(this.gb_P2);
            this.Gb_Players.Controls.Add(this.gb_P1);
            this.Gb_Players.Location = new System.Drawing.Point(410, 29);
            this.Gb_Players.Name = "Gb_Players";
            this.Gb_Players.Size = new System.Drawing.Size(264, 309);
            this.Gb_Players.TabIndex = 33;
            this.Gb_Players.TabStop = false;
            // 
            // rb_P3_Selected
            // 
            this.rb_P3_Selected.AutoSize = true;
            this.rb_P3_Selected.Location = new System.Drawing.Point(6, 252);
            this.rb_P3_Selected.Name = "rb_P3_Selected";
            this.rb_P3_Selected.Size = new System.Drawing.Size(28, 17);
            this.rb_P3_Selected.TabIndex = 30;
            this.rb_P3_Selected.TabStop = true;
            this.rb_P3_Selected.Text = " ";
            this.rb_P3_Selected.UseVisualStyleBackColor = true;
            // 
            // rb_P2_Selected
            // 
            this.rb_P2_Selected.AutoSize = true;
            this.rb_P2_Selected.Location = new System.Drawing.Point(6, 155);
            this.rb_P2_Selected.Name = "rb_P2_Selected";
            this.rb_P2_Selected.Size = new System.Drawing.Size(28, 17);
            this.rb_P2_Selected.TabIndex = 29;
            this.rb_P2_Selected.TabStop = true;
            this.rb_P2_Selected.Text = " ";
            this.rb_P2_Selected.UseVisualStyleBackColor = true;
            // 
            // rb_P1_Selected
            // 
            this.rb_P1_Selected.AutoSize = true;
            this.rb_P1_Selected.Location = new System.Drawing.Point(6, 63);
            this.rb_P1_Selected.Name = "rb_P1_Selected";
            this.rb_P1_Selected.Size = new System.Drawing.Size(28, 17);
            this.rb_P1_Selected.TabIndex = 28;
            this.rb_P1_Selected.TabStop = true;
            this.rb_P1_Selected.Text = " ";
            this.rb_P1_Selected.UseVisualStyleBackColor = true;
            // 
            // gb_P3
            // 
            this.gb_P3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gb_P3.Controls.Add(this.lb_P3_pts);
            this.gb_P3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_P3.Location = new System.Drawing.Point(38, 220);
            this.gb_P3.Name = "gb_P3";
            this.gb_P3.Size = new System.Drawing.Size(176, 82);
            this.gb_P3.TabIndex = 27;
            this.gb_P3.TabStop = false;
            this.gb_P3.Text = "Player 3";
            this.gb_P3.Visible = false;
            // 
            // lb_P3_pts
            // 
            this.lb_P3_pts.AutoSize = true;
            this.lb_P3_pts.Location = new System.Drawing.Point(16, 32);
            this.lb_P3_pts.Name = "lb_P3_pts";
            this.lb_P3_pts.Size = new System.Drawing.Size(72, 19);
            this.lb_P3_pts.TabIndex = 1;
            this.lb_P3_pts.Text = "Points:";
            // 
            // gb_P2
            // 
            this.gb_P2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gb_P2.Controls.Add(this.lb_P2_pts);
            this.gb_P2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_P2.Location = new System.Drawing.Point(38, 120);
            this.gb_P2.Name = "gb_P2";
            this.gb_P2.Size = new System.Drawing.Size(176, 82);
            this.gb_P2.TabIndex = 27;
            this.gb_P2.TabStop = false;
            this.gb_P2.Text = "Player 2";
            this.gb_P2.Visible = false;
            // 
            // lb_P2_pts
            // 
            this.lb_P2_pts.AutoSize = true;
            this.lb_P2_pts.Location = new System.Drawing.Point(16, 35);
            this.lb_P2_pts.Name = "lb_P2_pts";
            this.lb_P2_pts.Size = new System.Drawing.Size(72, 19);
            this.lb_P2_pts.TabIndex = 1;
            this.lb_P2_pts.Text = "Points:";
            // 
            // gb_P1
            // 
            this.gb_P1.BackColor = System.Drawing.Color.SkyBlue;
            this.gb_P1.Controls.Add(this.lb_P1_pts);
            this.gb_P1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_P1.Location = new System.Drawing.Point(38, 20);
            this.gb_P1.Name = "gb_P1";
            this.gb_P1.Size = new System.Drawing.Size(176, 82);
            this.gb_P1.TabIndex = 26;
            this.gb_P1.TabStop = false;
            this.gb_P1.Text = "Player 1";
            this.gb_P1.Visible = false;
            // 
            // lb_P1_pts
            // 
            this.lb_P1_pts.AutoSize = true;
            this.lb_P1_pts.Location = new System.Drawing.Point(16, 43);
            this.lb_P1_pts.Name = "lb_P1_pts";
            this.lb_P1_pts.Size = new System.Drawing.Size(72, 19);
            this.lb_P1_pts.TabIndex = 0;
            this.lb_P1_pts.Text = "Points:";
            // 
            // QandA_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jeopardy_final.Properties.Resources.jeopardy_logo;
            this.ClientSize = new System.Drawing.Size(686, 356);
            this.Controls.Add(this.Gb_Players);
            this.Controls.Add(this.btt_next_Q);
            this.Controls.Add(this.cb_correct_answer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btt_Submit);
            this.Controls.Add(this.tb_Question);
            this.Controls.Add(this.tb_Answer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_pts);
            this.Controls.Add(this.label1);
            this.Name = "QandA_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.QandA_Form_Load);
            this.Gb_Players.ResumeLayout(false);
            this.Gb_Players.PerformLayout();
            this.gb_P3.ResumeLayout(false);
            this.gb_P3.PerformLayout();
            this.gb_P2.ResumeLayout(false);
            this.gb_P2.PerformLayout();
            this.gb_P1.ResumeLayout(false);
            this.gb_P1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_pts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tb_Answer;
        private System.Windows.Forms.RichTextBox tb_Question;
        private System.Windows.Forms.Button btt_Submit;
        private System.Windows.Forms.ComboBox cb_correct_answer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btt_next_Q;
        private System.Windows.Forms.GroupBox Gb_Players;
        private System.Windows.Forms.GroupBox gb_P3;
        private System.Windows.Forms.Label lb_P3_pts;
        private System.Windows.Forms.GroupBox gb_P2;
        private System.Windows.Forms.Label lb_P2_pts;
        private System.Windows.Forms.GroupBox gb_P1;
        private System.Windows.Forms.Label lb_P1_pts;
        private System.Windows.Forms.RadioButton rb_P3_Selected;
        private System.Windows.Forms.RadioButton rb_P2_Selected;
        private System.Windows.Forms.RadioButton rb_P1_Selected;
    }
}