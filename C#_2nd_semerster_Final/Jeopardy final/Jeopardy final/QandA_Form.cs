using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeopardy_final
{
    public partial class QandA_Form : Form
    {
       
        

        public QandA_Form()
        {
            InitializeComponent();
            
        }

        private void QandA_Form_Load(object sender, EventArgs e)
        {
            // loads the players like the GameBoard does but accounting for the rb that points to which player is up
            int Player_Count = Options_Form.Player_Count;


            if (Player_Count == 1)
            {
                gb_P1.Visible = true;
                gb_P2.Visible = false;
                rb_P2_Selected.Visible = false;
                gb_P3.Visible = false;
                rb_P3_Selected.Visible = false;
            }
            if (Player_Count == 2)
            {
                gb_P1.Visible = true;
                gb_P2.Visible = true;
                gb_P3.Visible = false;
                rb_P3_Selected.Visible = false;
            }
            if (Player_Count == 3)
            {
                gb_P1.Visible = true;
                gb_P2.Visible = true;
                gb_P3.Visible = true;
            }
            gb_P1.Text = Options_Form.P1;
            gb_P2.Text = Options_Form.P2;
            gb_P3.Text = Options_Form.P3;
            lb_P1_pts.Text = GameBoard_Form.P1_pts.ToString();
            lb_P2_pts.Text = GameBoard_Form.P2_pts.ToString();
            lb_P3_pts.Text = GameBoard_Form.P3_pts.ToString();

            // pulls the answer and points from Gameboard
            int pts = GameBoard_Form.pts;
            
            string A = GameBoard_Form.A;
            lb_pts.Text = pts.ToString();
            tb_Answer.Text = A;


        }

        private void btt_Submit_Click(object sender, EventArgs e)
        {
            // lets the User decide if the given question for the answer is correct
            label6.Visible = true;
            cb_correct_answer.Visible = true;
        }

        private void btt_next_Q_Click(object sender, EventArgs e)
        {
            // points are given or take away based on which rb and combo box selection is selected
            int pts = GameBoard_Form.pts;

            if (cb_correct_answer.SelectedIndex == 0 && rb_P1_Selected.Checked)
            {
                GameBoard_Form.P1_pts = GameBoard_Form.P1_pts + pts;
            }
            if (cb_correct_answer.SelectedIndex == 1 && rb_P1_Selected.Checked)
            {
                GameBoard_Form.P1_pts = GameBoard_Form.P1_pts - pts;
            }
            if (cb_correct_answer.SelectedIndex == 0 && rb_P2_Selected.Checked)
            {
                GameBoard_Form.P2_pts = GameBoard_Form.P2_pts + pts;
            }
            if (cb_correct_answer.SelectedIndex == 1 && rb_P2_Selected.Checked)
            {
                GameBoard_Form.P2_pts = GameBoard_Form.P2_pts - pts;
            }
            if (cb_correct_answer.SelectedIndex == 0 && rb_P3_Selected.Checked)
            {
                GameBoard_Form.P3_pts = GameBoard_Form.P3_pts + pts;
            }
            if (cb_correct_answer.SelectedIndex == 1 && rb_P3_Selected.Checked)
            {
                GameBoard_Form.P3_pts = GameBoard_Form.P3_pts - pts;
            }

            GameBoard_Form.fin_questions++;





            this.Hide();
            
        }
    }
}
