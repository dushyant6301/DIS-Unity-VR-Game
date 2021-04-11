using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalSound : MonoBehaviour
{
    public AudioSource metalSound;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 1)
        {
            metalSound.Play();
        }
    }
}
