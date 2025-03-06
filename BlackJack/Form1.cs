using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        int s = 0;
        int j = 0;
        int k = 0;
        string Castigat_Dealer_BlackJack = "A castigat Dealer prin BlackJack!";
        string Castigat_Dealer = "A castigat Dealer!";
        string Castigat_Player = "A castigat Player";
        string Egalitate = "Este Egalitate!";
        string NuCastigaNimeni = "Nu a castigat nimeni!";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void HIT_Click(object sender, EventArgs e)
        {

            var rnd = new Random();
            s = (s + rnd.Next(1, 11));
            Player_Score.Text = s.ToString();
           





            j = (j + rnd.Next(1, 11));
           // Dealer_Score.Text = j.ToString();

            if (s > 21)
            {
                HIT.Enabled = false;
            }
          

        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void STAND_Click(object sender, EventArgs e)
        {
            int value;
            if (Int32.TryParse(Dealer_Score.Text, out value))
            {
                if (s > value&& value>21&&s<=21)
                {
                   
                    Result.Text = Castigat_Player;
                    
                }
                if (s == value && s < 21 && value < 21)
                {
                    
                    Result.Text = Egalitate;
                    
                }
                if (s == 21)
                {
                    
                    Result.Text = Castigat_Player;
                    
                }
                if (s > value && value < 21 && s <= 21)
                {
                    
                    Result.Text = Castigat_Player;
                    
                }
                if (value > s&&value<=21)
                {
                   
                    Result.Text = Castigat_Dealer;
                    
                }
                if (value > 21 && s > 21)
                {
                    
                    Result.Text = NuCastigaNimeni;
                    
                }
                if (value > 21 && s <= 21)
                {
                    
                    Result.Text = Castigat_Player;
                    
                }
                if (value < 21 && s > 21)
                {
                    
                    Result.Text = Castigat_Dealer;
                    
                }
                
            }
            Dealer_Score.Visible = true;
            STAND.Enabled = false;
            HIT.Enabled = false;
            RESET.Enabled = true;
            
        }

        private void START_Click(object sender, EventArgs e)
        {
            
            var rnd = new Random();
            j = (j + rnd.Next(1, 11)) + rnd.Next(1, 11); 
            //Dealer_Score.Text = j.ToString();
            s = (s + rnd.Next(1, 11))+rnd.Next(1,11);
            Player_Score.Text = s.ToString();
            START.Enabled = false;
            HIT.Enabled = true;
            STAND.Enabled = true;
            RESET.Enabled = false;
            Dealer_Score.Visible = false;



            if (j <= 16)
            { while (j <= 17)
                {
                    j = j + rnd.Next(1, 11);

                }
                if (j == 21)
                {
                    Result.Text = Castigat_Dealer_BlackJack;
                    Dealer_Score.Text = j.ToString();
                    Dealer_Score.Visible = true;
                    STAND.Enabled = false;
                    HIT.Enabled = false;
                    RESET.Enabled = true;

                }
                    Dealer_Score.Text = j.ToString();
            }
            
            else Dealer_Score.Text = j.ToString();
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}
//Player_Score.Visible = false;

//While (scorul dealerului <=21 se mai adauga un numar random la final se afiseaza scorul dealerului )
/*var random = new Random();
var list = new List<string> { "one", "two", "three", "four" };
int index = random.Next(list.Count);*/
