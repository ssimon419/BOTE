using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Card
{
    void Start()
    {
        this.name = "Archer";
        this.attack = 1;
        this.health = 1;
        this.manaCost = 2;
    }
}
