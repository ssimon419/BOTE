using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Executioner : Card
{
    void Start()
    {
        this.name = "Executioner";
        this.attack = 6;
        this.health = 3;
        this.manaCost = 5;
    }
}
