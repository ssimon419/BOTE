using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regent : Card
{
    void Start()
    {
        this.name = "Regent";
        this.attack = 9;
        this.health = 7;
        this.manaCost = 5;
    }

    // Method passes the board of the game in; place all cards being played under the board object?
    void addCounters(Board board)
    {
        string tag = gameObject.tag;
        if (tag.Equals("playerOne"))
        {
            for (int boardIndex = 0; boardIndex < board.GetCardsOnBoard(tag).getCardList().Count; boardIndex++)
            {
                Card target = board.GetCardsOnBoard(tag).getCardList()[boardIndex];
                target.ChangeHealth(-2);
                target.ChangeAttack(-2);
            }
        }

        if (tag.Equals("playerTwo"))
        {
            for (int boardIndex = 0; boardIndex < board.GetCardsOnBoard(tag).getCardList().Count; boardIndex++)
            {
                Card target = board.GetCardsOnBoard(tag).getCardList()[boardIndex];
                target.ChangeHealth(-2);
                target.ChangeAttack(-2);
            }
        }

    }


}
