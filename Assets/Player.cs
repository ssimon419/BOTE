using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerName;
    int maxMana = 5;
    int mana = 5;
    
    int health = 30;

    Card[] playerHand = new Card[7];
    Card[] playerBoard = new Card[5];

    // Mutators
    public void ManaAdd(int addValue)
    {
        maxMana += addValue;
    }

    public void HealthAdd(int addValue)
    {
        health -= addValue;
    }

    // Accessors

    public int GetHealth()
    {
        return health;
    }

    public int GetMana()
    {
        return mana;
    }

    public void AddCardtoHand(Card card)
    {
        int i = 0;
        while (i < playerHand.Length - 1)
        {
            if (playerHand[i] == null)
            {
                playerHand[i] = card;
            }
            i++;
        }
    }

    public void RemoveFromHand(Card card)
    {
        maxMana -= card.GetManaCost();
        for (int i = 0; i < (playerHand.Length - 1); i++)
        {
            if (playerHand[i].Equals(card))
            {
                playerHand[i] = null;
            }
        }
    }
}
