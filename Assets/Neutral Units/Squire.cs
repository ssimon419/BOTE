using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squire : Card
{
    void Start()
    {
        this.name = "Squire";
        this.attack = 5;
        this.health = 1;
        this.manaCost = 3;
    }

    public override void Special()
    {
        Hand onBoard = board.GetCardsOnBoard(gameObject.tag);

        List<Card> cardList = onBoard.getCardList();
        
        for (int i = 0; i < cardList.Count; i++)
        {
            if (cardList[i] is Knight)
            {
                cardList[i].AddAttack(2);
                cardList[i].AddHealth(2);
            }
        }
    }
}

