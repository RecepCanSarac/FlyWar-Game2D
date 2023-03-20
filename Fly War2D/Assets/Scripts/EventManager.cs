using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void enemyDeadDelegate();
    public static enemyDeadDelegate enemyDead;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (EnemyMove.enemyHealth <= 0)
        {
            if (enemyDead != null)
            {
                enemyDead();
            }
        }
    }
}
