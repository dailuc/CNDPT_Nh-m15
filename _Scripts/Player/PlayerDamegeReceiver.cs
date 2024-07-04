using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamegeReceiver : DamageReceiver
{

    public override void Receiver(int damege)
    {
        base.Receiver(damege);
        if (this.IsDead())
        {
            PlayerCtrl.instance.playerStatus.Dead();
            UIManager.instance.btnGameRestart.SetActive(true);
        }
    }
}
