using UnityEngine;
using System.Collections;

public class CharacterControls : MonoBehaviour {
	
	public float Speed = 10.0f;
	public float MaxVelocityChange = 20.0f;
	private bool Traction = false;
	public float AddforceNumber = 500f;
	
	
	void Update(){
		if (Input.GetKeyDown (KeyCode.Mouse1)) 
		{
			Vector3 temp = new Vector3(Random.Range(-AddforceNumber,AddforceNumber),Random.Range(-AddforceNumber,AddforceNumber),Random.Range(-AddforceNumber,AddforceNumber));
			rigidbody.AddForce(temp);
		}
	}

	void Awake () {
	}

	public void DoMovement(float xValue, float yValue)
	{
		if (Traction) {
			// Calculate how fast we should be moving
			Vector3 targetVelocity = new Vector3(xValue, 0, yValue);
			targetVelocity = transform.TransformDirection(targetVelocity);
			targetVelocity *= Speed;
			
			// Apply a force that attempts to reach our target velocity
			Vector3 velocity = rigidbody.velocity;
			Vector3 velocityChange = (targetVelocity - velocity);
			velocityChange.x = Mathf.Clamp(velocityChange.x, -MaxVelocityChange, MaxVelocityChange);
			velocityChange.z = Mathf.Clamp(velocityChange.z, -MaxVelocityChange, MaxVelocityChange);
			velocityChange.y = 0;
			rigidbody.AddForce(velocityChange, ForceMode.VelocityChange);
			
		}
		
		Traction = false;
	}

	
	void FixedUpdate () {
		DoMovement (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"));
	}
	
	void OnCollisionStay () {
		Traction = true;    
	}

}