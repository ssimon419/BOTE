using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merchant : Card
{
    void Start()
    {
        this.name = "Merchant";
        this.attack = 1;
        this.health = 1;
        this.manaCost = 1;
    }

    void addMana(Player player)
    {
        player.ManaAdd(2);
    }
}

