using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jester : Card
{
    void Start()
    {
        this.name = "Jester";
        this.attack = 2;
        this.health = 7;
        this.manaCost = 4;
    }
}
