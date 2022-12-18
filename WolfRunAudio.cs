using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfRunAudio : MonoBehaviour
{

    [SerializeField] public AudioSource wolfRunSound;

    public void wolfResetRunSound()
    {
        wolfRunSound.enabled = false;
    }

    public void WolfRunSound()
    {
        wolfRunSound.enabled = true;
    }
}
