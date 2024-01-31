using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSprite : MonoBehaviour

    
{

    public Sprite sp1, sp2;

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("start");
        GetComponent<SpriteRenderer>().sprite = sp2;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("exit");
        GetComponent<SpriteRenderer>().sprite = sp1;
    }
}
