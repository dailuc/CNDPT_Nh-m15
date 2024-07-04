using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    public SelfDestroy selfDestroy;

    static private EnemyCtrl instance;

    public static EnemyCtrl Instance { get => instance; }
    private EnemyCtrl()
    {
        
    }

    private void Awake()
    {
        EnemyCtrl.instance = this;
        selfDestroy = GetComponent<SelfDestroy>();

    }
}
