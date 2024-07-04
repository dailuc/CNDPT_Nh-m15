using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadDesSpawner : MonoBehaviour
{
    [SerializeField] protected float distance = 0f;

    private void FixedUpdate()
    {
        this.UpdateRoad();
    }
    protected virtual void UpdateRoad()
    {
        this.distance = Vector2.Distance(PlayerCtrl.instance.transform.position,
                                            transform.position);
        if (distance >= 70f) Destroy(gameObject);
    }
  
}
