using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSound : MonoBehaviour
{
    private AudioSource sound;

    private void Start()
    {
        sound = this.GetComponent<AudioSource>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        sound.Play();
        collision.gameObject.GetComponent<AudioSource>().volume = 0.0f;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        sound.Stop();
        collision.gameObject.GetComponent<AudioSource>().volume = 0.3f;
    }
}
