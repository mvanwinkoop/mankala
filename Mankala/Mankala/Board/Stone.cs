using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Stone: GameObject
{
    //constructor stone
    public Stone()
    {
    }

    public override void Initialize()
    {
        textureName = "stone";
        base.Initialize();
    }

}