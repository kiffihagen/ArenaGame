using UnityEngine;
using System.Collections;

public class BaseAbility : MonoBehaviour
{

    public string AbilityName;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Use()
    {
        Debug.Log("Using ability " + AbilityName);
    }
}
