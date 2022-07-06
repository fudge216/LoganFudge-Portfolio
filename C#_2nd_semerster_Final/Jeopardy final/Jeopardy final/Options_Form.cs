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
    public partial class Options_Form : Form
    {
      
        //Options form sets the player names as wells as sets how many players are in each game.
        
       //name variables and player count across the game
        
        public static int Player_Count = 0;
        public static string P1;
        public static string P2;
        public static string P3;

        public Options_Form()
        {
            InitializeComponent();
        }

      
       // based on which radio button is selected, the text boxes on the form and player count changes
  
        private void rb_1player_CheckedChanged(object sender, EventArgs e)
        {
            tb_P1_Name.Visible = true;
            lb_P1.Visible = true;
            tb_P2_Name.Visible = false;
            tb_P2_Name.Text = " ";
            lb_P2.Visible = false;
            tb_P3_Name.Visible = false;
            tb_P3_Name.Text = " ";
            lb_P3.Visible = false;

            Player_Count = 1;

        }

        private void rb_2player_CheckedChanged(object sender, EventArgs e)
        {
            tb_P1_Name.Visible = true;
            lb_P1.Visible = true;
            tb_P2_Name.Visible = true;
            lb_P2.Visible = true;
            tb_P3_Name.Visible = false;
            tb_P3_Name.Text = " ";
            lb_P3.Visible = false;
            
            Player_Count = 2;
        }

        private void rb_3player_CheckedChanged(object sender, EventArgs e)
        {
            tb_P1_Name.Visible = true;
            lb_P1.Visible = true;
            tb_P2_Name.Visible = true;
            lb_P2.Visible = true;
            tb_P3_Name.Visible = true;
            lb_P3.Visible = true;
            
            Player_Count = 3;
        }

       // the play button sets the scores to 0 so if the game is started over
       //  names are loaded into global variables
       // gameboard for loaded 
        
        private void btn_Play_Click(object sender, EventArgs e)
        {
            GameBoard_Form.P1_pts = 0;
            GameBoard_Form.P2_pts = 0;
            GameBoard_Form.P3_pts = 0;


            P1 = tb_P1_Name.Text;
            P2 = tb_P2_Name.Text;
            P3 = tb_P3_Name.Text;
            
            this.Hide();
            GameBoard_Form game = new GameBoard_Form();
            
            game.Show();
            

           

            
        }
    }
}
