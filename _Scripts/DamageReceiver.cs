using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{

    public int hp = 1;

    public virtual bool IsDead()
    {
        return this.hp <= 0;
    }
    public virtual void Receiver(int damege)
    {
        this.hp -= damege;
    }
}
