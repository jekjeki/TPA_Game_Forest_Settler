using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSwordSound : MonoBehaviour
{
    [SerializeField] public AudioSource swordSound;


    public void resetSwordSound()
    {
        swordSound.enabled = false;
    }

    public void swordSoundOn()
    {
        swordSound.enabled = true;
    }
}
