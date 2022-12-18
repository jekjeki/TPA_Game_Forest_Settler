using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public bool death;
    public float Timer;
    public float Cooldown;
    public GameObject Enemy;
    public string EnemyName;
    GameObject LastEnemy;

    // Start is called before the first frame update
    void Start()
    {
        death = false;
        this.gameObject.name = EnemyName + "spawn point";
    }

    // Update is called once per frame
    void Update()
    {
        if(death == true)
        {
            Timer += Time.deltaTime;
        }

        if(Timer >= Cooldown)
        {
            Enemy.transform.position = transform.position;

            Instantiate(Enemy);
            LastEnemy = GameObject.Find(Enemy.name + "(Clone)");
            LastEnemy.name = EnemyName;
            death = false;
            Timer = 0;
        }
    }
}
