using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfIdleAudio : MonoBehaviour
{

    [SerializeField] AudioSource idleSound;

   public void wolfResetIdleSound()
    {
        idleSound.enabled = false;
    }

    public void wolfIdleSound()
    {
        idleSound.enabled = true;
    }
}
