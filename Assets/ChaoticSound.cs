using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaoticSound : MonoBehaviour
{
    public AudioSource chaoticSound;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 3)
        {
            chaoticSound.Play();
        }
    }
}
