using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jester : Card
{
    void Start()
    {
        this.name = "Jester";
        this.attack = 1;
        this.health = 1;
        this.manaCost = 4;
    }
}
