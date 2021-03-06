using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class MoucheGB : Ennemis
{    
    public GameObject gbTiles;
    public GameObject deathVFX;

    private void Awake()
    {
        GetComponent<AIDestinationSetter>().target = GameObject.FindGameObjectWithTag("Player").transform;
        gbTiles = TilesManager.Instance.tileSets[1];
    }
    public override void Death()
    {
        //change to GB visual
        TilesManager.Instance.ChangeTileSet(gbTiles);
        Instantiate(deathVFX, transform.position, Quaternion.identity);
        base.Death();
    }
}
