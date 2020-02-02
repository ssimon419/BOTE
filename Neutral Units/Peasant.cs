using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peasant : Card
{
    void Start()
    {
        this.name = "Peasant";
        this.attack = 2;
        this.health = 1;
        this.manaCost = 1;
    }

}
