using System;
using UnityEngine;
using System.Collections;
using Object = UnityEngine.Object;

public class ProjectileSpawner : MonoBehaviour
{

    public Transform TestProjectile;
    public Transform ExitPoint;
    public float SpawnDistance = 1f;
    public Vector2 InitialDirection = new Vector2(0, 1);

    public Vector2 TestSpawnDirection = new Vector2(1, 0);

    private bool _fDown = false;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if (Input.GetKey("f"))
	    {
	        _fDown = true;
	    }
	    else if (_fDown)
        {
            _fDown = false;
            SpawnProjectile(TestProjectile, ExitPoint.position, TestSpawnDirection);
        }
	}

    private float DirectionToRotation(Vector2 direction)
    {
        var angle = Vector2.Angle(direction, InitialDirection);
        if (direction.x < 0)
        {
            angle = 360 - angle;
        }
        Debug.Log("The angle between " + InitialDirection + " and " + direction + " is " + angle);
        return angle;
    }

    public BaseProjectile SpawnProjectile(Object projectilePrefab, Vector3 spawnPosition, Vector2 direction)
    {
        //direction.
        var rotation = Quaternion.Euler(0, DirectionToRotation(direction), 0);
        var position = spawnPosition + new Vector3(direction.x * SpawnDistance, 0, direction.y * SpawnDistance);
        Debug.Log("Spawning projectile at " + position + ", with rotation: " + rotation.eulerAngles);
        return (Instantiate(projectilePrefab, position, rotation) as Transform).gameObject.GetComponent<BaseProjectile>();
    }

    public BaseProjectile SpawnProjectile(Object projectilePrefab, Vector3 spawnPosition, Vector3 direction)
    {
        return SpawnProjectile(projectilePrefab, spawnPosition, new Vector2(direction.x, direction.z));
    }
}
