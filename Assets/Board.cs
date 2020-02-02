using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    Hand playerOneCardsOnBoard = new Hand(5);
    Hand playerTwoCardsOnBoard = new Hand(5);


    // Accessor
    public Hand GetCardsOnBoard(string tag)
    {
        if (tag == "playerOne")
        {
            return playerOneCardsOnBoard;
        }

        else if (tag == "playerTwo")
        {
            return playerTwoCardsOnBoard;
        }

        else return null;
    }

    // Returns the side of the board of the opponent of the tag passed
    public Hand GetOpponentCardsOnBoard(string tag)
    {
        if(tag == "playerOne")
        {
            return playerTwoCardsOnBoard;
        }

        else if (tag == "playerTwo")
        {
            return playerOneCardsOnBoard;
        }

        else return null;
    }

    // Adds cards specific to each player's side of the board
    public void AddCardToBoard(Card card)
    {
        string tag = card.gameObject.tag;

        if (tag.Equals("playerOne"))
        {
            playerOneCardsOnBoard.AddCard(card);
        }

        if (tag.Equals("playerTwo"))
        {
            playerTwoCardsOnBoard.AddCard(card);
        }
    }
}
