using System;
using System.Collections.Generic;
using System.Text;

namespace MyStory
{

    class SuperVillain : SuperHuman
    {
        public string _evil { get; set; }
    public SuperVillain (string name, int hp, int strength, string deranged)  : base(name, hp, strength)
    {
        _name = name;
        _hp = hp;
        _strength = strength;
          _evil = deranged;
    }
}
}