using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private static int user_Choice, com_Choice, temp, total, wins, loses;
    private void resetGame()
    {
        total = 0;
        wins = 0;
        loses = 0;
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Game()
    {
        int random = new Random().Next(1, 4);
        int? tempRandom=null;
        if (random == user_Choice|| random == tempRandom)
        {
                random = new Random().Next(1, 4);
        }
        else
        {
            com_Choice = random;
            tempRandom = random;
        }
        
        switch (user_Choice)
        {
            case 1:
                if (com_Choice == 2)
                {
                    Label1.Text = "Computer chose Paper";
                    temp = 1;
                }
                else
                {
                    Label1.Text = "Computer chose Scissors";
                    temp = 2;
                }
                break;
            case 2:
                if (com_Choice == 3)
                {
                    Label1.Text = "Computer chose Scissors";
                    temp = 1;
                }
                else
                {
                    Label1.Text = "Computer chose Rock";
                    temp = 2;
                }
                break;
            case 3:
                if (com_Choice == 1)
                {
                    Label1.Text = "Computer chose Rock";
                    temp = 1;
                }
                else
                {
                    Label1.Text = "Computer chose Paper";
                    temp = 2;
                }
                break;
                
        }
        if (temp == 1)
        {
            Label2.Text = "The computer won!";
            total++;
            loses++;
        }
        if (temp==2)
        {
            Label2.Text = "You won!";
            wins++;
            total++;
        }
    }
    protected void gameCount()
    {
        Label4.Text = Convert.ToString(total);
        Label5.Text = Convert.ToString(wins);
        Label6.Text = Convert.ToString(loses);
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        user_Choice = 1;
        Game();
        gameCount();
        Label3.Text = "You chose Rock";
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        user_Choice = 2;
        Game();
        Label3.Text = "You chose Paper";
        gameCount();
    }

    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        user_Choice = 3;
        Game();
        Label3.Text = "You chose Scissors";
        gameCount();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        resetGame();
        gameCount();
        Label1.Text = "";
        Label2.Text = "";
        Label3.Text = "";
    }
}