using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private List<Card> rngSetPlayerOne;
    private List<Card> rngSetPlayerTwo;

    private GameObject player1Object;
    private GameObject player2Object;

    private int playerTurn = 1;

    public Player playerOne;
    public Player playerTwo;

    void Update()
    {
        if (playerOne.GetHealth() > 0 && playerTwo.GetHealth() > 0)
        {
            if (playerTurn == 1)
            {
                // Start of round, player's mana is refilled from previous round.
                /* Could possibly switch turns after each attack?
                 * 
                 */
            }

            if (playerTurn == 2)
            {
                playerTwo.manaRefill();
            }
        }


        // Win conditions
        if (playerOne.GetHealth() > 0)
        {
            // Player One Wins
        } 
        else
        {
            // Player Two Wins
        }
    }
    void Awake()
    {
        // Creates playerOne and playerTwo player objects for clarity
        player1Object = GameObject.Find("playerOne");
        player2Object = GameObject.Find("playerTwo");
        playerOne = player1Object.GetComponent<Player>();
        playerTwo = player2Object.GetComponent<Player>();
    }

    // Start is called before the first frame update

    // Returns player based on tag passed into the function
    public Player GetPlayer(string tag)
    {
        if (tag == "playerOne")
        {
            return playerOne;
        }

        else if (tag == "playerTwo")
        {
            return playerTwo;
        }

        return null;
    }

    // Returns opposite player of the tag passed in
    public Player GetPlayerOpponent(string tag)
    {
        if (tag == "playerOne")
        {
            return playerTwo;
        }

        else if (tag == "playerTwo")
        {
            return playerOne;
        }

        return null;
    }

}
