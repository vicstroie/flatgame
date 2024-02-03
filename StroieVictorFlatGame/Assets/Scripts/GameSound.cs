using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSounds : MonoBehaviour
{
    private AudioSource sound;

    private void Start()
    {
        sound = this.GetComponent<AudioSource>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        sound.Play();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        sound.Stop();
    }
}
