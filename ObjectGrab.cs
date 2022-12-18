using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGrab : MonoBehaviour
{
    [SerializeField] public GameObject sword;
    [SerializeField] public GameObject handPlayer;
    [SerializeField] public GameObject swordInHand;

    Vector3 swordPos;
    Vector3 handPlayerPos;

    void Start()
    {
        swordPos = sword.transform.position;
        handPlayerPos = handPlayer.transform.position;
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            swordInHand.SetActive(true);
            sword.transform.position = handPlayerPos;
        }
    }
}
