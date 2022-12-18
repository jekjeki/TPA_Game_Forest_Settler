using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearEnemyAudio : MonoBehaviour
{
    [SerializeField]AudioSource deathSound;
    public void DeathSound()
    {
        deathSound.enabled = true;
    }

    public void resetSOund()
    {
        deathSound.enabled = false;
    }
}
