using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Web_Controls_and_HTML_Controls
{
    public partial class TicTacToe : System.Web.UI.Page
    {
        private static bool turn = true;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (turn)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }

            turn = !turn;
            button.Enabled = false;
            CheckForWinner();

        }

        protected void Restart_Click(object sender, EventArgs e)
        {
            this.Button1.Text = this.Button2.Text = this.Button3.Text =
            this.Button4.Text = this.Button5.Text = this.Button6.Text =
            this.Button7.Text = this.Button8.Text = this.Button9.Text = "";

            this.Button1.Enabled = this.Button2.Enabled = this.Button3.Enabled =
            this.Button4.Enabled = this.Button5.Enabled = this.Button6.Enabled =
            this.Button7.Enabled = this.Button8.Enabled = this.Button9.Enabled = true;

            this.Label2.Text = "The winner is: ";
            turn = true;
        }

        protected void CheckForWinner()
        {
            bool thereIsWinner = false;
            if (this.Button1.Text == this.Button2.Text && this.Button1.Text == this.Button3.Text && (!this.Button1.Enabled) ||
            this.Button4.Text == this.Button5.Text && this.Button4.Text == this.Button6.Text && (!this.Button4.Enabled) ||
            this.Button7.Text == this.Button8.Text && this.Button7.Text == this.Button9.Text && (!this.Button7.Enabled) ||
            this.Button1.Text == this.Button4.Text && this.Button1.Text == this.Button7.Text && (!this.Button1.Enabled) ||
            this.Button2.Text == this.Button5.Text && this.Button2.Text == this.Button8.Text && (!this.Button2.Enabled) ||
            this.Button3.Text == this.Button6.Text && this.Button3.Text == this.Button9.Text && (!this.Button3.Enabled) ||
            this.Button1.Text == this.Button5.Text && this.Button1.Text == this.Button9.Text && (!this.Button1.Enabled) ||
            this.Button3.Text == this.Button5.Text && this.Button3.Text == this.Button7.Text && (!this.Button3.Enabled))
            {
                thereIsWinner = true;
            }

            if (thereIsWinner)
            {
                this.DisableButtons();

                if (turn)
                {
                    this.Label2.Text += "Player 2! Press the Restart button to play again!";
                }
                else
                {
                    this.Label2.Text += "Player 1! Press the Restart button to play again!";
                }
            }
        }

        protected void DisableButtons()
        {
            try
            {
                foreach (var control in Controls)
                {
                    Button button = (Button)control;
                    if (button.Text != "Restart")
                    {
                        button.Enabled = false;
                    }
                }
            }
            catch { }
        }
    }
}