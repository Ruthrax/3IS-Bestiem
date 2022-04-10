using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class MoucheVer : Ennemis
{
    new private void Awake()
    {
        GetComponent<AIDestinationSetter>().target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    protected override void Death()
    {
        //Passage en mode Fishing-Game
        base.Death();
    }
}
