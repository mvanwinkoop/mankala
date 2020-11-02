using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Player
{
    int score;
    int playerNumber;

    //constructor player
    public Player(int pNumber)
    {
        score = 0;
        playerNumber = pNumber;
    }

    public int getPlayerNumber()
    {
        return playerNumber;
    }

    //property score, als vervanger voor GetScore methode
    public int Score
    {
        get { return score; }
        set
        {
            if (value < 0)
                return;
            score = value;
        }
    }


    public bool AddToScore(int points)
    {
        return false;
    }
}

