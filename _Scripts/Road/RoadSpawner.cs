using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class RoadSpawner : MonoBehaviour
{
    [SerializeField] protected GameObject roadSpawner;
    [SerializeField] protected GameObject roadPrefab;
    [SerializeField] protected GameObject roadSpawnPos;
    [SerializeField] protected float distance = 0f;
    [SerializeField] protected int roadLayerOrder = 20;
    private void Awake()
    {
        roadPrefab = GameObject.Find("RoadPrefab");
        roadSpawnPos = GameObject.Find("RoadSpawnPos");

        this.roadPrefab.SetActive(false);
        Vector3 newPos = roadPrefab.transform.position;
        newPos.z = this.roadLayerOrder;
        this.roadPrefab.transform.position = newPos;

        this.Spawn(this.roadPrefab.transform.position);

    }
    private void FixedUpdate()
    {
        this.UpdateRoad();
    }
    protected virtual void UpdateRoad()
    {
        this.distance = Vector2.Distance(PlayerCtrl.instance.transform.position,
                                            this.roadSpawner.transform.position);
        if (distance >= 40f) this.Spawn();
    }
    protected virtual void Spawn()
    {
        Vector3 pos = this.roadSpawnPos.transform.position;
        pos.x = 0f;
        pos.z = this.roadLayerOrder;

        Spawn(pos);
    }
    protected virtual void Spawn(Vector3 position)
    {
        this.roadSpawner = Instantiate(this.roadPrefab, position, this.roadPrefab.transform.rotation);
        this.roadSpawner.transform.parent = transform;
        this.roadSpawner.SetActive(true);
    }
}
