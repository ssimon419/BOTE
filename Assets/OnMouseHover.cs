using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseHover : MonoBehaviour
{
    public GameObject disappearingObj;

    // Start is called before the first frame update
    void Start()
    {
       // disappearingObj.SetActive(false);
    }

    void OnMouseEnter ()
    {
        disappearingObj.SetActive(true);
    //    StartCoroutine(waitPlease());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
