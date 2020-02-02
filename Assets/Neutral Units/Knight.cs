using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : Card
{
    void Start()
    {
        this.name = "Knight";
        this.attack = 5;
        this.health = 8;
        this.manaCost = 2;
        this.taunt = true;
    }

}
