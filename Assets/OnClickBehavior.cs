using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class OnClickBehavior : MonoBehaviour
{
    public bool toggle;
    public GameObject myObject;
    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {
        toggle = false;
    }

    void OnMouseDown ()
    {
        toggle = !toggle;
        if (toggle)
        {
            Destroy(gameObject);
        }
        else
        {
            Instantiate(myObject);
        }
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
