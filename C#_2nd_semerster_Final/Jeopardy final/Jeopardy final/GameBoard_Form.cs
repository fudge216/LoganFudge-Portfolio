using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeopardy_final
{
    public partial class GameBoard_Form : Form
    {
        // sets up several global variables that will be accssed by the diffent forms
       
       public static int pts;
       public static string A;
       public static string Q;
       public static int P1_pts;
       public static int P2_pts;
       public static int P3_pts;
       public static int fin_questions = 0;

        // instantiates other froms to be used below pulling variables from those form vital to this form
        Options_Form options = new Options_Form();
        int Player_Count = Options_Form.Player_Count;

        XmlData XmlData = new XmlData();
        List<String> xmllist = new List<String>();

        
        



        public GameBoard_Form()
        {
            InitializeComponent();


        }

        /// <summary>
        /// shows game over gb and creates two strings, 
        /// one that states a winner based  on the calcs of Determine_Winner method and
        /// the other that takes the points and names and sends them to the serialization class to be added to the DB.
        /// the OldScore pulls all of the old games into a listbox
        /// </summary>
        private void Run_GameEnd()
        {
            Serialization serialization =  new Serialization();
            string game = "";
            gb_GameOver.Visible = true;
            lb_win_text.Text ="Congrats " + Determine_Winner() +", You Win!!!";
            game += Options_Form.P1 + " score = " + P1_pts+" " + Options_Form.P2 + "score = " + P2_pts + " "  + Options_Form.P3 + " score = " + P3_pts;
            serialization.Serialize(game);
            lb_PreviousScores.DataSource = serialization.Old_Scores();
            
        }
       
        //whoever has a larger point value wins and the winner's name is sent to string in Run_GameEnd
        private string Determine_Winner()
        {
            string Winner="";
           

            if(Options_Form.Player_Count == 1)
            {
                Winner = Options_Form.P1;
            }

            if(Options_Form.Player_Count == 2 || Options_Form.Player_Count == 3 && P1_pts >P2_pts&& P1_pts > P3_pts)
            {
                Winner = Options_Form.P1;
            }
            if(Options_Form.Player_Count == 2 || Options_Form.Player_Count == 3 && P2_pts >P1_pts && P2_pts > P3_pts)
            {
                Winner = Options_Form.P2;
            }
            if (Options_Form.Player_Count == 2 || Options_Form.Player_Count == 3 && P3_pts > P1_pts && P3_pts > P2_pts)
            {
                Winner = Options_Form.P3;
            }

            return Winner;
        }



        //shows options form
        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            options.Show();
        }
        // GB's for each player's name and points are determined by the player count 
        private void button21_Click(object sender, EventArgs e)
        {

            if (Player_Count == 1)
            {
                gb_P1.Visible = true;
                gb_P2.Visible = false;
                gb_P3.Visible = false;
            }
            if (Player_Count == 2)
            {
                gb_P1.Visible = true;
                gb_P2.Visible = true;
                gb_P3.Visible = false;
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
            lb_P1_pts.Text = P1_pts.ToString();
            lb_P2_pts.Text = P2_pts.ToString();
            lb_P3_pts.Text = P3_pts.ToString();

            // xml is read to pull the data from the provided xml file for the cats questions and answers
             xmllist = XmlData.Get_XMLData();

            // catagories are added to text boxes
            tb_Cat1.Text = xmllist[0];
            tb_Cat2.Text = xmllist[16];
            tb_Cat3.Text = xmllist[32];
            tb_Cat4.Text = xmllist[48];
            tb_Cat5.Text = xmllist[64];

            
        }
       // updates the players points on the GameBoard and validates an ending based on if a certian number of questions have been answered. If they have GameEnd is run 
        
        private void btt_Update_Click(object sender, EventArgs e)
        {
            this.lb_P1_pts.Text = P1_pts.ToString();
            this.lb_P2_pts.Text = P2_pts.ToString();
            this.lb_P3_pts.Text = P3_pts.ToString();

            if (GameBoard_Form.fin_questions > 24)
            {
                Run_GameEnd();
            }

        }


        // button resets everything and allows for a new game to start
        private void btt_Play_Again_Click(object sender, EventArgs e)
        {

            gb_GameOver.Visible = false;
            this.Hide();
            options.Show();
        }

       // each button is loaded with the Q and A from the xml based on the correct question for each cat,  As well as the points which are all sent to the Qand A form 

        private void btt_Cat1_Q1_Click(object sender, EventArgs e)
        {
            QandA_Form QandA = new QandA_Form();
            xmllist = XmlData.Get_XMLData();
            
            pts = Convert.ToInt32(xmllist[1]);
            A = xmllist[2];
            Q = xmllist[3];

            QandA.Show();
            btt_Cat1_Q1.Visible = false;
           
        }
        #region Game Buttons
        private void btt_Cat1_Q2_Click(object sender, EventArgs e)
        {
            QandA_Form QandA = new QandA_Form();
            xmllist = XmlData.Get_XMLData();

            pts = Convert.ToInt32(xmllist[4]);
            A = xmllist[5];
            Q = xmllist[6];

            QandA.Show();
            btt_Cat1_Q2.Visible = false;
            
        }

        private void btt_Cat1_Q3_Click(object sender, EventArgs e)
        {
            QandA_Form QandA = new QandA_Form();
            xmllist = XmlData.Get_XMLData();

            pts = Convert.ToInt32(xmllist[7]);
            A = xmllist[8];
            Q = xmllist[9];

            QandA.Show();
            btt_Cat1_Q3.Visible = false;
            fin_questions++;
        }

        private void btt_Cat1_Q4_Click(object sender, EventArgs e)
        {
            {
                QandA_Form QandA = new QandA_Form();
                xmllist = XmlData.Get_XMLData();

                pts = Convert.ToInt32(xmllist[10]);
                A = xmllist[11];
                Q = xmllist[12];

                QandA.Show();
                btt_Cat1_Q4.Visible = false;
               
            }
        }

        private void btt_Cat1_Q5_Click(object sender, EventArgs e)
        {
            QandA_Form QandA = new QandA_Form();
            xmllist = XmlData.Get_XMLData();

            pts = Convert.ToInt32(xmllist[13]);
            A = xmllist[14];
            Q = xmllist[15];

            QandA.Show();
            btt_Cat1_Q5.Visible = false;
           
        }

        private void btt_Cat2_Q1_Click(object sender, EventArgs e)
        {
            QandA_Form QandA = new QandA_Form();
            xmllist = XmlData.Get_XMLData();

            pts = Convert.ToInt32(xmllist[17]);
            A = xmllist[18];
            Q = xmllist[19];

            QandA.Show();
            btt_Cat2_Q1.Visible = false;
           
        }

        private void btt_Cat2_Q2_Click(object sender, EventArgs e)
        {
            QandA_Form QandA = new QandA_Form();
            xmllist = XmlData.Get_XMLData();

            pts = Convert.ToInt32(xmllist[20]);
            A = xmllist[21];
            Q = xmllist[22];

            QandA.Show();
            btt_Cat2_Q2.Visible = false;
      
        }

        private void btt_Cat2_Q3_Click(object sender, EventArgs e)
        {
            QandA_Form QandA = new QandA_Form();
            xmllist = XmlData.Get_XMLData();

            pts = Convert.ToInt32(xmllist[23]);
            A = xmllist[24];
            Q = xmllist[25];

            QandA.Show();
            btt_Cat2_Q3.Visible = false;
         
        }

        private void btt_Cat2_Q4_Click(object sender, EventArgs e)
        {
            QandA_Form QandA = new QandA_Form();
            xmllist = XmlData.Get_XMLData();

            pts = Convert.ToInt32(xmllist[26]);
            A = xmllist[27];
            Q = xmllist[28];

            QandA.Show();
            btt_Cat2_Q4.Visible = false;
  
        }

        private void btt_Cat2_Q5_Click(object sender, EventArgs e)
        {
            QandA_Form QandA = new QandA_Form();
            xmllist = XmlData.Get_XMLData();

            pts = Convert.ToInt32(xmllist[29]);
            A = xmllist[30];
            Q = xmllist[31];

            QandA.Show();
            btt_Cat2_Q5.Visible = false;
        
        }

        private void btt_Cat3_Q1_Click(object sender, EventArgs e)
        {
            QandA_Form QandA = new QandA_Form();
            xmllist = XmlData.Get_XMLData();

            pts = Convert.ToInt32(xmllist[33]);
            A = xmllist[34];
            Q = xmllist[35];

            QandA.Show();
            btt_Cat3_Q1.Visible = false;
           
        }

        private void btt_Cat3_Q2_Click(object sender, EventArgs e)
        {
            QandA_Form QandA = new QandA_Form();
            xmllist = XmlData.Get_XMLData();

            pts = Convert.ToInt32(xmllist[36]);
            A = xmllist[37];
            Q = xmllist[38];

            QandA.Show();
            btt_Cat3_Q2.Visible = false;
        
        }

        private void btt_Cat3_Q3_Click(object sender, EventArgs e)
        {
            QandA_Form QandA = new QandA_Form();
            xmllist = XmlData.Get_XMLData();

            pts = Convert.ToInt32(xmllist[39]);
            A = xmllist[40];
            Q = xmllist[41];

            QandA.Show();
            btt_Cat3_Q3.Visible = false;
         
        }

        private void btt_Cat3_Q4_Click(object sender, EventArgs e)
        {
            QandA_Form QandA = new QandA_Form();
            xmllist = XmlData.Get_XMLData();

            pts = Convert.ToInt32(xmllist[42]);
            A = xmllist[43];
            Q = xmllist[44];

            QandA.Show();
            btt_Cat3_Q4.Visible = false;
 
        }

        private void btt_Cat3_Q5_Click(object sender, EventArgs e)
        {
            QandA_Form QandA = new QandA_Form();
            xmllist = XmlData.Get_XMLData();

            pts = Convert.ToInt32(xmllist[45]);
            A = xmllist[46];
            Q = xmllist[47];

            QandA.Show();
            btt_Cat3_Q5.Visible = false;

        }

        private void btt_Cat4_Q1_Click(object sender, EventArgs e)
        {
            QandA_Form QandA = new QandA_Form();
            xmllist = XmlData.Get_XMLData();

            pts = Convert.ToInt32(xmllist[49]);
            A = xmllist[50];
            Q = xmllist[51];

            QandA.Show();
            btt_Cat4_Q1.Visible = false;

        }

        private void btt_Cat4_Q2_Click(object sender, EventArgs e)
        {
            QandA_Form QandA = new QandA_Form();
            xmllist = XmlData.Get_XMLData();

            pts = Convert.ToInt32(xmllist[52]);
            A = xmllist[53];
            Q = xmllist[54];

            QandA.Show();
            btt_Cat4_Q2.Visible = false;

        }

        private void btt_Cat4_Q3_Click(object sender, EventArgs e)
        {
            QandA_Form QandA = new QandA_Form();
            xmllist = XmlData.Get_XMLData();

            pts = Convert.ToInt32(xmllist[55]);
            A = xmllist[56];
            Q = xmllist[57];

            QandA.Show();
            btt_Cat4_Q3.Visible = false;
         
        }

        private void btt_Cat4_Q4_Click(object sender, EventArgs e)
        {
            QandA_Form QandA = new QandA_Form();
            xmllist = XmlData.Get_XMLData();

            pts = Convert.ToInt32(xmllist[58]);
            A = xmllist[59];
            Q = xmllist[60];

            QandA.Show();
            btt_Cat4_Q4.Visible = false;

        }

        private void btt_Cat4_Q5_Click(object sender, EventArgs e)
        {
            QandA_Form QandA = new QandA_Form();
            xmllist = XmlData.Get_XMLData();

            pts = Convert.ToInt32(xmllist[61]);
            A = xmllist[62];
            Q = xmllist[63];

            QandA.Show();
            btt_Cat4_Q5.Visible = false;

        }

        private void btt_Cat5_Q1_Click(object sender, EventArgs e)
        {
            QandA_Form QandA = new QandA_Form();
            xmllist = XmlData.Get_XMLData();

            pts = Convert.ToInt32(xmllist[65]);
            A = xmllist[66];
            Q = xmllist[67];

            QandA.Show();
            btt_Cat5_Q1.Visible = false;

        }

        private void btt_Cat5_Q2_Click(object sender, EventArgs e)
        {
            QandA_Form QandA = new QandA_Form();
            xmllist = XmlData.Get_XMLData();

            pts = Convert.ToInt32(xmllist[68]);
            A = xmllist[69];
            Q = xmllist[70];

            QandA.Show();
            btt_Cat5_Q2.Visible = false;
    
        }

        private void btt_Cat5_Q3_Click(object sender, EventArgs e)
        {
            QandA_Form QandA = new QandA_Form();
            xmllist = XmlData.Get_XMLData();

            pts = Convert.ToInt32(xmllist[71]);
            A = xmllist[72];
            Q = xmllist[73];

            QandA.Show();
            btt_Cat5_Q3.Visible = false;
         
        }

        private void btt_Cat5_Q4_Click(object sender, EventArgs e)
        {
            QandA_Form QandA = new QandA_Form();
            xmllist = XmlData.Get_XMLData();

            pts = Convert.ToInt32(xmllist[74]);
            A = xmllist[75];
            Q = xmllist[76];

            QandA.Show();
            btt_Cat5_Q4.Visible = false;

        }

        private void btt_Cat5_Q5_Click(object sender, EventArgs e)
        {
            QandA_Form QandA = new QandA_Form();
            xmllist = XmlData.Get_XMLData();

            pts = Convert.ToInt32(xmllist[77]);
            A = xmllist[78];
            Q = xmllist[79];

            QandA.Show();
            btt_Cat5_Q5.Visible = false;
   
        }


        #endregion


    }
}
