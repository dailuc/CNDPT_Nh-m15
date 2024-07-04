using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomSpawner : Spawner
{


    private void Reset()
    {
        this.prefabName = "BomPrefab";
        this.spawnPosName = "BomSpawnPos";

        this.timeSpawn = 0f;
        this.timeDelay = 3f;
        this.maxObj = 100;
    }
  
}
