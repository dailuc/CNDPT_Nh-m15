using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDameReceiver : DamageReceiver

{
    private void Reset()
    {
        this.hp = 3;
    }
    public override void Receiver(int damege)
    {
        base.Receiver(damege);
        if (this.IsDead())
        {
            EffectsManager.instance.SpawnVFX("Explosion_B_01", transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

}
