using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuppetMouche : Ennemis
{
    protected override void Death()
    {
        //Transforme Frog en Kermit
        //PlayerSpriteManager.Instance.SetCurrentSprites(PlayerSpriteManager.Instance.KermitSprites);
        base.Death();
    }
}
