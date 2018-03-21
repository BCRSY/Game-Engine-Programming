using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerarotation : MonoBehaviour {
	public Quaternion rotation = Quaternion.Euler(0, 0, 0);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
			if(Input.GetKey(KeyCode.A))
			{
			transform.rotation = Quaternion.Euler(0, -30, 0);
			}
			if(Input.GetKey(KeyCode.D))
			{
			transform.rotation = Quaternion.Euler(0, 30, 0);
			}
	}
}
