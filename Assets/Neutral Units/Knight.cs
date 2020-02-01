using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : Card
{
    void Start()
    {
        this.name = "Knight";
        this.attack = 4;
        this.health = 3;
        this.manaCost = 2;
        this.taunt = true;
    }

}
