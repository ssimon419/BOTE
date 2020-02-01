using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regent : Card
{
    void Start()
    {
        this.name = "Regent";
        this.attack = 6;
        this.health = 3;
        this.manaCost = 5;
    }

    void addCounters(Card target)
    {
        target.ChangeHealth(-2);
        target.ChangeAttack(-2);
    }

}
