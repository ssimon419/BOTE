using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Card
{
    void Start()
    {
        this.name = "Archer";
        this.attack = 3;
        this.health = 2;
        this.manaCost = 2;
    }
}
