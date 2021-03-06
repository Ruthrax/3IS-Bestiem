using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class MoucheVer : Ennemis
{
    public GameObject deathVFX;

    private void Awake()
    {
        GetComponent<AIDestinationSetter>().target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public override void Death()
    {
        //Passage en mode Fishing-Game
        Instantiate(deathVFX, transform.position, Quaternion.identity);
        base.Death();
    }
}
