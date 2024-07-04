using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DamegeSender : MonoBehaviour
{

    [Header("Damege Sender")]
    public int damege = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageReceiver damageReceiver = collision.GetComponent<DamageReceiver>();
        if (damageReceiver == null) return;
        damageReceiver.Receiver(damege);
    }
}
