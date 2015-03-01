using UnityEngine;
using System.Collections;

public class MouseTouchSimulator : MonoBehaviour
{

    private bool _down = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Mouse0))
	    {
	        _down = true;
	    }
        else if (_down)
        {
            _down = false;
            gameObject.GetComponent<TouchController>().ProcessTouchEvent(Input.mousePosition);
        }
	}
}
