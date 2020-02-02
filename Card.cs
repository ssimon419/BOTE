using UnityEngine;

public class Card : MonoBehaviour
{
    protected int attack;
    protected int health;
    protected int manaCost;
    protected bool taunt = false;

    static protected Board board = GameObject.FindGameObjectWithTag("board").GetComponent<Board>();
    static protected Game game = GameObject.FindGameObjectWithTag("game").GetComponent<Game>();

    // When the card is selected to attack
    public void Attack(Card target)
    {

        // If target is not on same side, 
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