using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Card
{
    void Start()
    {
        this.name = "Mage";
        this.attack = 5;
        this.health = 7;
        this.manaCost = 3;
        this.taunt = false;
    }
}
