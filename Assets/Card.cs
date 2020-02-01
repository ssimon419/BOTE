using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    protected int attack;
    protected int health;
    protected int manaCost;
    protected bool taunt = false;
    protected bool onBoard = false;


    // When the card is selected to attack
    public void Attack(Card target)
    {
        // If target is not on same side, 
        if (!(gameObject.CompareTag(target.tag)))
        {   
            // Changes health of attacking card
            ChangeHealth(target.GetAttack());
            // Changes health of the defending card
            target.ChangeHealth(GetAttack());
        }
    }

    // Mutator Functions
    // Healing passes through as a negative integer
    public void ChangeHealth(int addValue)
    {
        this.health -= addValue;
    }

    public void ChangeAttack(int addValue)
    {
        this.attack -= addValue;
    }

    public void PlaceOnBoard()
    {
        this.onBoard = true;
    }

    // Accessor Functions
    public int GetAttack()
    {
        return this.attack;
    }

    public int GetManaCost()
    {
        return this.manaCost;
    }

}