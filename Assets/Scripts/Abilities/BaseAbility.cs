using UnityEngine;
using System.Collections;

public class BaseAbility : MonoBehaviour
{

    private GameObject _player;

    public GameObject Player
    {
        get { return _player; }

        set
        {
            _player = value;
            _projectileSpawner = value.GetComponent<ProjectileSpawner>();
        }
    }

    public string AbilityName;

    public Transform ProjectilePrefab;

    private ProjectileSpawner _projectileSpawner;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Use(Vector2 direction)
    {
        _projectileSpawner.SpawnProjectile(ProjectilePrefab, Player.transform.position, direction);
        Debug.Log("Using ability " + AbilityName);
    }
}
