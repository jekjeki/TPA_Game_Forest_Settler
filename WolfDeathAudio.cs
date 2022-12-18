using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfDeathAudio : MonoBehaviour
{
    [SerializeField] AudioSource wolfDeathSound;

    public void resetWolfDeathSound()
    {
        wolfDeathSound.enabled = false;
    }

    public void WolfDeathSound()
    {
        wolfDeathSound.enabled = true;
    }
}
