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
    public void AddMana(int addValue)
    {
        maxMana += addValue;
    }

    public void AddHealth(int addValue)
    {
        health += addValue;
    }

    public void Damage(int value)
    {
        health -= value;
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
    // Places card on board, corresponding with the player
    public void PlayCard(Card card)
    {
        // Mana gets lowered
        mana -= card.GetManaCost();
        // Triggers card special ability when played
        card.Special();

        hand.getCardList().Remove(card);

        Board board = GameObject.FindGameObjectWithTag("board").GetComponent<Board>();

        board.AddCardToBoard(card);
    }

    public void manaRefill()
    {
        this.mana = maxMana;
    }

}
