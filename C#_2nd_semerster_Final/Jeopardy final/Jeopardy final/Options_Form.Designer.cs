
namespace Jeopardy_final
{
    partial class Options_Form
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
            this.tb_P1_Name = new System.Windows.Forms.TextBox();
            this.tb_P3_Name = new System.Windows.Forms.MaskedTextBox();
            this.tb_P2_Name = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_1player = new System.Windows.Forms.RadioButton();
            this.rb_2player = new System.Windows.Forms.RadioButton();
            this.rb_3player = new System.Windows.Forms.RadioButton();
            this.lb_P1 = new System.Windows.Forms.Label();
            this.lb_P2 = new System.Windows.Forms.Label();
            this.lb_P3 = new System.Windows.Forms.Label();
            this.btn_Play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_P1_Name
            // 
            this.tb_P1_Name.Location = new System.Drawing.Point(5, 244);
            this.tb_P1_Name.Name = "tb_P1_Name";
            this.tb_P1_Name.Size = new System.Drawing.Size(100, 20);
            this.tb_P1_Name.TabIndex = 0;
            this.tb_P1_Name.Visible = false;
            // 
            // tb_P3_Name
            // 
            this.tb_P3_Name.Location = new System.Drawing.Point(278, 244);
            this.tb_P3_Name.Name = "tb_P3_Name";
            this.tb_P3_Name.Size = new System.Drawing.Size(100, 20);
            this.tb_P3_Name.TabIndex = 1;
            this.tb_P3_Name.Visible = false;
            // 
            // tb_P2_Name
            // 
            this.tb_P2_Name.Location = new System.Drawing.Point(142, 244);
            this.tb_P2_Name.Name = "tb_P2_Name";
            this.tb_P2_Name.Size = new System.Drawing.Size(100, 20);
            this.tb_P2_Name.TabIndex = 2;
            this.tb_P2_Name.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Fuchsia;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(73, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Players";
            // 
            // rb_1player
            // 
            this.rb_1player.AutoSize = true;
            this.rb_1player.BackColor = System.Drawing.Color.DodgerBlue;
            this.rb_1player.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_1player.Location = new System.Drawing.Point(38, 161);
            this.rb_1player.Name = "rb_1player";
            this.rb_1player.Size = new System.Drawing.Size(35, 20);
            this.rb_1player.TabIndex = 5;
            this.rb_1player.TabStop = true;
            this.rb_1player.Text = "1";
            this.rb_1player.UseVisualStyleBackColor = false;
            this.rb_1player.CheckedChanged += new System.EventHandler(this.rb_1player_CheckedChanged);
            // 
            // rb_2player
            // 
            this.rb_2player.AutoSize = true;
            this.rb_2player.BackColor = System.Drawing.Color.DodgerBlue;
            this.rb_2player.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_2player.Location = new System.Drawing.Point(175, 161);
            this.rb_2player.Name = "rb_2player";
            this.rb_2player.Size = new System.Drawing.Size(35, 20);
            this.rb_2player.TabIndex = 6;
            this.rb_2player.TabStop = true;
            this.rb_2player.Text = "2";
            this.rb_2player.UseVisualStyleBackColor = false;
            this.rb_2player.CheckedChanged += new System.EventHandler(this.rb_2player_CheckedChanged);
            // 
            // rb_3player
            // 
            this.rb_3player.AutoSize = true;
            this.rb_3player.BackColor = System.Drawing.Color.DodgerBlue;
            this.rb_3player.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_3player.Location = new System.Drawing.Point(306, 161);
            this.rb_3player.Name = "rb_3player";
            this.rb_3player.Size = new System.Drawing.Size(35, 20);
            this.rb_3player.TabIndex = 7;
            this.rb_3player.TabStop = true;
            this.rb_3player.Text = "3";
            this.rb_3player.UseVisualStyleBackColor = false;
            this.rb_3player.CheckedChanged += new System.EventHandler(this.rb_3player_CheckedChanged);
            // 
            // lb_P1
            // 
            this.lb_P1.AutoSize = true;
            this.lb_P1.BackColor = System.Drawing.Color.DodgerBlue;
            this.lb_P1.Location = new System.Drawing.Point(33, 204);
            this.lb_P1.Name = "lb_P1";
            this.lb_P1.Size = new System.Drawing.Size(45, 13);
            this.lb_P1.TabIndex = 8;
            this.lb_P1.Text = "Player 1";
            this.lb_P1.Visible = false;
            // 
            // lb_P2
            // 
            this.lb_P2.AutoSize = true;
            this.lb_P2.BackColor = System.Drawing.Color.DodgerBlue;
            this.lb_P2.Location = new System.Drawing.Point(170, 204);
            this.lb_P2.Name = "lb_P2";
            this.lb_P2.Size = new System.Drawing.Size(45, 13);
            this.lb_P2.TabIndex = 9;
            this.lb_P2.Text = "Player 2";
            this.lb_P2.Visible = false;
            // 
            // lb_P3
            // 
            this.lb_P3.AutoSize = true;
            this.lb_P3.BackColor = System.Drawing.Color.DodgerBlue;
            this.lb_P3.Location = new System.Drawing.Point(301, 204);
            this.lb_P3.Name = "lb_P3";
            this.lb_P3.Size = new System.Drawing.Size(45, 13);
            this.lb_P3.TabIndex = 10;
            this.lb_P3.Text = "Player 3";
            this.lb_P3.Visible = false;
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(155, 301);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(75, 23);
            this.btn_Play.TabIndex = 11;
            this.btn_Play.Text = "Let\'s Play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // Options_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jeopardy_final.Properties.Resources.jeopardy_logo;
            this.ClientSize = new System.Drawing.Size(390, 351);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.lb_P3);
            this.Controls.Add(this.lb_P2);
            this.Controls.Add(this.lb_P1);
            this.Controls.Add(this.rb_3player);
            this.Controls.Add(this.rb_2player);
            this.Controls.Add(this.rb_1player);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_P2_Name);
            this.Controls.Add(this.tb_P3_Name);
            this.Controls.Add(this.tb_P1_Name);
            this.Name = "Options_Form";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_P1_Name;
        private System.Windows.Forms.MaskedTextBox tb_P3_Name;
        private System.Windows.Forms.MaskedTextBox tb_P2_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_1player;
        private System.Windows.Forms.RadioButton rb_2player;
        private System.Windows.Forms.RadioButton rb_3player;
        private System.Windows.Forms.Label lb_P1;
        private System.Windows.Forms.Label lb_P2;
        private System.Windows.Forms.Label lb_P3;
        private System.Windows.Forms.Button btn_Play;
    }
}