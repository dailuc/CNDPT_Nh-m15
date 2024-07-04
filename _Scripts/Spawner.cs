using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spawner")]
    [SerializeField] protected GameObject objPrefab;
    [SerializeField] protected GameObject objSpawnPos;
    [SerializeField] protected List<GameObject> listObjs;
    [SerializeField] protected float timeSpawn = 0f;
    [SerializeField] protected float timeDelay = 3f;
    [SerializeField] protected string prefabName = "";
    [SerializeField] protected string spawnPosName = "";
    [SerializeField] protected int maxObj = 1;
    [SerializeField] protected int layerOrder = 0;

    private void Awake()
    {
        this.objPrefab = GameObject.Find(this.prefabName);
        this.objSpawnPos = GameObject.Find(this.spawnPosName);
        this.layerOrder = (int)this.objPrefab.transform.position.z;

        objPrefab.SetActive(false);

        listObjs = new List<GameObject>();
    }
    private void Update()
    {

        this.checkDead();
        this.Spawn();
    }
    public virtual GameObject Spawn()
    {
        //if (PlayerCtrl.instance.damageReceiver.IsDead()) return null;
        if (this.listObjs.Count >= maxObj) return null;

        timeSpawn += Time.deltaTime;
        if (timeSpawn < timeDelay) return null;
        timeSpawn = 0f;

        Vector3 position = this.objSpawnPos.transform.position;
        position.z = this.layerOrder;
        return this.Spawn(position);
       
    }
    public virtual GameObject Spawn(Vector3 position)
    {
        GameObject obj = Instantiate(objPrefab);
        obj.transform.position = position;
        obj.transform.parent = transform;
        obj.SetActive(true);
        listObjs.Add(obj);

        return obj;
    }
    public void checkDead()
    {
        for (int i = 0; i < listObjs.Count; i++)
        {
            if (listObjs[i] == null) listObjs.RemoveAt(i);
        }
    }
}
