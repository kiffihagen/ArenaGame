using UnityEngine;
using System.Collections;

public class BaseProjectile : MonoBehaviour
{

    public float InitialForce = 1000;

	// Use this for initialization
	void Start () {
	    this.rigidbody.AddForce(this.transform.forward * InitialForce);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
