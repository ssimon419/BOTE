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

    public override void Special()
    {
        GameObject.Find(gameObject.tag).GetComponent<Player>().AddHealth(5);
    }
}
