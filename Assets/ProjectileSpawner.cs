using UnityEngine;
using System.Collections;

public class ProjectileSpawner : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public BaseProjectile SpawnProjectile(Object projectilePrefab, Vector3 spawnPosition, Vector2 direction)
    {
        Instantiate(projectilePrefab, spawnPosition, Quaternion.Euler())
    }
}
