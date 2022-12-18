using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearRunAudio : MonoBehaviour
{
    [SerializeField] AudioSource runSound;

    public void RunSound()
    {
        runSound.enabled = true;
    }

    public void ResetSoundRun()
    {
        runSound.enabled = false;
    }
}
