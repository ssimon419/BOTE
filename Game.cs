using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private List<Card> rngSetPlayerOne;
    private List<Card> rngSetPlayerTwo;

    private GameObject player1Object;
    private GameObject player2Object;

    public Player playerOne;
    public Player playerTwo;
    
    private void Awake()
    {
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
