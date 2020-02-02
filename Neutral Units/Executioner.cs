using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Executioner : Card
{
    void Start()
    {
        this.name = "Executioner";
        this.attack = 6;
        this.health = 3;
        this.manaCost = 5;
    }

    public override void Special()
    {
        Hand onBoard = board.GetOppponentCardsOnBoard(gameObject.tag);

        List<Card> cardList = onBoard.getCardList();

        int rng = Random.Range(0, cardList.Count);

        cardList[rng].Damage(50);
    }
}
