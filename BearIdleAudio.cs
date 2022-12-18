using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearIdleAudio : MonoBehaviour
{
    [SerializeField] AudioSource idleSound;

    public void IdleSound()
    {
        idleSound.enabled = true;
    }

    public void resetSound()
    {
        idleSound.enabled = false;
    }
}
