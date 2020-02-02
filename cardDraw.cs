using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardDraw : MonoBehaviour
{
    // array of all possible units
    Random random = new Random();
    String[] units = new string[] { "Archer", "Executioner", "Jester", "Knight", "Mage", "Merchant", "Peasant", "Priest", "Regent", "Squire" };
    public void cardDraw(Player player) {
        
        player.Addcard(units[random.Next(10)]);

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
 