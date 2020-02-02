using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    private List<Card> cardsInList = new List<Card>();

    private int maxCapacity;
    private GameObject cardGameObject;
    private Card baseCard;
    
    // Constructor
    public Hand(int capacity)
    {
        this.maxCapacity = capacity;
    }
    private void Awake()
    {
        cardGameObject = GameObject.Find("Card");
        baseCard = cardGameObject.GetComponent<Card>();
    }
    
    // Call upon this when you choose a card during the card selection phase at the beginning of the game
    public void AddCard(Card card)
    {
        cardsInList.Add(card);
    }

    // Accessors
    public List<Card> getCardList()
    {
        return cardsInList;
    }

    public int GetCapacity()
    {
        return maxCapacity;
    }
}
