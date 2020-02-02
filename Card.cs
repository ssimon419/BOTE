using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    protected int attack;
    protected int health;
    protected int manaCost;
    protected bool shield = false;

    static protected Board board = GameObject.FindGameObjectWithTag("board").GetComponent<Board>();
    static protected Game game = GameObject.FindGameObjectWithTag("game").GetComponent<Game>();

    // When the card is selected to attack
    public void Attack(Card target)
    {
        bool tauntExists = false;
        List<Card> opponentList = board.GetOpponentCardsOnBoard(gameObject.tag).getCardList();

        for (int handIndex = 0; handIndex < opponentList.Count - 1;  handIndex++)
        {
            if (opponentList[handIndex].shield == true)
            {
                tauntExists = true;
            }
        }

        if (tauntExists)
        {
            // If target is not on the same side and has taunt
            if (!(gameObject.CompareTag(target.tag)) && target.shield == true)
            {
                // Changes health of attacking card
                Damage(target.GetAttack());
                // Changes health of the defending card
                target.Damage(GetAttack());
            }
            // Otherwise, nothing happens (cant attack creatues w/o taunt if there is a taunt creature on the field)
        }

        // If target is not on same side, and does taunt does not exist
        if (!(gameObject.CompareTag(target.tag)))
        {   
            // Changes health of attacking card
            Damage(target.GetAttack());
            // Changes health of the defending card
            target.Damage(GetAttack());
        }
      
    }

    // If the card has no special function, then calling this does nothing
    public virtual void Special() { }

    // Mutator Functions
    // Healing passes through as a negative integer
    public void AddHealth(int value)
    {
        this.health += value;
    }

    // Changes attack value
    public void AddAttack(int value)
    {
        this.attack += value;
    }

    // If damage is caused to the card
    public void Damage(int value)
    {
        this.health -= value;
    }

    // Destroys card when this method is called
    public void removeCard()
    {
        Destroy(gameObject);
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