using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMouseHover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseExit()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
