using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Executioner : Card
{
    void Start()
    {
        this.name = "Executioner";
        this.attack = 1;
        this.health = 1;
        this.manaCost = 5;
    }
}
