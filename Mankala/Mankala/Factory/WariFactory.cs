using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WariFactory : GameFactory
{
    public override Board CreateBoard(GameRules rules, Player p1, Player p2)
    {
        int x = 0;
        int y = 100;

        Board b = new WariBoard();
        
        //create the right amount of holes:
        for (int i = 0; i < rules.amountOfHolesPerPlayer; i++)
        {
            Hole newHole = new Hole(rules.piecesPerHole, p1);
            x += 100;
            newHole.setPosition(x, y);
            b.addHole(newHole);
        }

        y += 100;

        for (int i = 0; i < rules.amountOfHolesPerPlayer; i++)
        {
            Hole newHole = new Hole(rules.piecesPerHole, p2);

            newHole.setPosition(x, y);
            x -= 100;
            b.addHole(newHole);
        }

        return b;
    }


}