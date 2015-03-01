using UnityEngine;
using System.Collections;

public class BaseProjectile : MonoBehaviour
{

    public float InitialForce = 1000;

    private bool _gDown = false;

	// Use this for initialization
	void Start () {
        Debug.Log("Adding " + InitialForce + " force to projectile.");
        this.rigidbody.AddForce(this.transform.forward * InitialForce);
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetKey("g"))
        //{
        //    _gDown = true;
        //}
        //else if (_gDown)
        //{
        //    _gDown = false;
        //    Debug.Log("Adding force to projectile");
        //    this.rigidbody.AddForce(this.transform.forward * InitialForce);
        //}
	}
}
