using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;


class Game
{
    Player p1, p2, currentPlayer;
    Board board;
    GameRules rules;

    public Game(GameFactory factory, GameRules gameRules)
    {
        p1 = new Player(1);
        p2 = new Player(2);

        currentPlayer = p1;

        rules = gameRules;

        board = factory.CreateBoard(rules, p1, p2);

        Initialize();
    }



    public bool HasGameEnded()
    {
        return false;
    }

    Player nextPlayer()
    {
        if (currentPlayer == p1)
            return p2;
        else
            return p1;
    }

    public void MakeMove()
    {

    }

    public void Initialize()
    {
        board.Initialize();
    }

    public void Update()
    {
        board.Update();
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        board.Draw(spriteBatch);
    }
}

