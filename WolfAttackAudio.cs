using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAttackAudio : MonoBehaviour
{

    [SerializeField] AudioSource wolfAttackSound;

    public void ResetWolfAudioAttack()
    {
        wolfAttackSound.enabled = false;
    }

    public void WolfAttackSound()
    {
        wolfAttackSound.enabled = true;
    }
}
