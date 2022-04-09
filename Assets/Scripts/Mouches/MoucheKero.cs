using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoucheKero : Ennemis
{
    protected override void Death()
    {
        //Transforme Frog en Kero
        PlayerSpriteManager.Instance.SetCurrentSprites(PlayerSpriteManager.Instance.KeroSprites);
        base.Death();
    }
}
