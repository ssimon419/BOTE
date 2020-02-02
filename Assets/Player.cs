using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerName;

    private int maxMana = 5;
    private int mana = 5;
    private int health = 30;
    private Hand hand = new Hand(7);

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

    public Hand GetHand()
    {
        return hand;
    }

    // Functions
    public void PlayCard(Card card)
    {
        mana -= card.GetManaCost();
        hand.getCardList().Remove(card);
    }

}
