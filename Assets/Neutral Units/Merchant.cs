﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merchant : Card
{
    void Start()
    {
        this.name = "Merchant";
        this.attack = 1;
        this.health = 2;
        this.manaCost = 1;
    }

    public override void Special()
    {
        addMana(game.GetPlayer(gameObject.tag));
    }
    void addMana(Player player)
    {
        player.AddMana(2);
    }
}

