using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terra : Card
{
    void Start()
    {
        this.name = "Terra";
        this.attack = 0;
        this.health = 0;
        this.manaCost = 3;
    }

    public override void Special()
    {
        Player target = game.GetPlayerOpponent(gameObject.tag);
        target.Damage(8);

    }
}
