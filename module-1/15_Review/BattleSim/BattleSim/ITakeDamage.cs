using System;
using System.Collections.Generic;
using System.Text;

namespace BattleSim
{
    //splitting out so we can have other objects that 
    //are able to take damage
    //maybe a tree or cow
    public interface ITakeDamage
    {
        int Health { get; }
        void DecreaseHealth(int damage);
    }
}
