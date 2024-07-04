using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    static public PlayerCtrl instance ;
    public DamageReceiver damageReceiver;
    public PlayerStatus playerStatus;
    private void Awake()
    {
        PlayerCtrl.instance = this ;
        damageReceiver = GetComponent<DamageReceiver>();
        playerStatus = GetComponent<PlayerStatus>();
    }
   
}
