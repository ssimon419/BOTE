using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Card
{
    void Start()
    {
        this.name = "Mage";
        this.attack = 4;
        this.health = 2;
        this.manaCost = 3;
        this.shield = false;
    }

    public override void Special()
    {
        Hand onBoard = board.GetOpponentCardsOnBoard(gameObject.tag);

        List<Card> cardList = onBoard.getCardList();

        for (int i = 0; i < cardList.Count; i++)
        {
            cardList[i].Damage(2);
        }
    }
}
