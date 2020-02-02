using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Card
{
    void Start()
    {
        this.name = "Mage";
        this.attack = 4;
        this.health = 2;
        this.manaCost = 3;
        this.taunt = false;
    }
}
