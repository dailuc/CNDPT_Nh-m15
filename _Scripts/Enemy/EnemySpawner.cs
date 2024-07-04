using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class EnemySpawner : Spawner
{
   

    private void Reset()
    {
        this.prefabName = "EnemyPrefab";
        this.spawnPosName = "EnemySpawnPos";

        this.timeSpawn = 0f;
        this.timeDelay = 0.5f;
    }
}
