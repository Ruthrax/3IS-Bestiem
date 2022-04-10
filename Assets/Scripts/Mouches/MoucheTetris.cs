using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class MoucheTetris : Ennemis
{
    new private void Awake()
    {
        GetComponent<AIDestinationSetter>().target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    protected override void Death()
    {
        //Transforme Frog en pièce de tetris
        base.Death();
    }
}
