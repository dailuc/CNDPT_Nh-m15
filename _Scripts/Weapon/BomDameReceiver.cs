using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomDameReceiver : DamageReceiver
{
    private void Reset()
    {
        this.hp = 1;
    }
    public override void Receiver(int damege)
    {
        base.Receiver(damege);
        Debug.Log("dungs");
        EffectsManager.instance.SpawnVFX("Explosion_A_01",transform.position,transform.rotation);
        if (IsDead())
        {
            Destroy(gameObject);
        }

    }
}
