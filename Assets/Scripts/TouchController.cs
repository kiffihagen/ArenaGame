using UnityEngine;
using System.Collections;

public class TouchController : MonoBehaviour
{

    private ProjectileSpawner _projectileSpawner;

	// Use this for initialization
	void Start ()
	{
	    _projectileSpawner = gameObject.GetComponent<ProjectileSpawner>();
	}
	
	// Update is called once per frame
	void Update () {
	    foreach (var touch in Input.touches)
	    {
	        if (touch.phase == TouchPhase.Began)
	        {
	            Debug.Log("Touched position: " + touch.position + " of x:[0, " + Screen.width + "], y:[0, " + Screen.height + "]");
                //var worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 0));
                //Debug.Log("Touched world position: " + worldPosition);
	            var ray = Camera.main.ScreenPointToRay(touch.position);
	            var plane = new Plane(Vector3.up, transform.position);
	            float distance;
	            if (plane.Raycast(ray, out distance))
	            {
	                var pos = ray.GetPoint(distance);
                    Debug.Log("World position: " + pos);
                    _projectileSpawner.SpawnProjectile(_projectileSpawner.TestProjectile,
                        _projectileSpawner.ExitPoint.position, pos.normalized);
	            }
	        }
	    }
	}
}
