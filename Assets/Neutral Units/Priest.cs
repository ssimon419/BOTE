using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Priest : Card
{
    void Start()
    {
        this.name = "Priest";
        this.attack = 3;
        this.health = 4;
        this.manaCost = 4;
    }
}
