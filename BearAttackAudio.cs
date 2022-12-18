using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearAttackAudio : MonoBehaviour
{

    [SerializeField] AudioSource attackSound; 

   public void AttackSound()
    {
        attackSound.enabled = true;
    }

    public void resetAttackSound()
    {
        attackSound.enabled = false;
    }
}
