using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private List<Card> rngSetPlayerOne;
    private List<Card> rngSetPlayerTwo;

    private GameObject player1Object;
    private GameObject player2Object;
    private Player player1;
    private Player player2;
    
    private void Awake()
    {
        player1Object = GameObject.Find("playerOne");
        player2Object = GameObject.Find("playerTwo");
        player1 = player1Object.GetComponent<Player>();
        player2 = player2Object.GetComponent<Player>();
    }

    // Start is called before the first frame update

    void Start()
    { 
       
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
