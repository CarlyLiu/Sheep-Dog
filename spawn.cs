/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public flock prefab;
    public float SpawnRadius = 10;
    public int SpawnCount = 10;

    void Awake () {
        for (int i = 0; i < SpawnCount; i++) {
        // Vector2 pos = new Vector2(transform.position.x, transform.position.z) + (Random.insideUnitCircle * SpawnRadius);
        flock boid = Instantiate(prefab);
        // boid.transform.position = pos;
        boid.transform.position = new Vector3(transform.position.x + Random.Range(-1f, 1f) * SpawnRadius, transform.position.y, transform.position.z+ Random.Range(-1f, 1f)* SpawnRadius);
        // boid.transform.up = Random.insideUnitCircle;
        }
    }
}
 */