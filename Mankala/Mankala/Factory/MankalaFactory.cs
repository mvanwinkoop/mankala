using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MankalaFactory : GameFactory
{
    public override Board CreateBoard(GameRules rules, Player p1, Player p2)
    {
        return base.CreateBoard(rules, p1, p2);
    }
}

