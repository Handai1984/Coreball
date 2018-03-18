using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeipanMove : MonoBehaviour {
    public float speed=200f;
	
	void Start () {
	}
	
	
	void Update () {
        this.transform.Rotate(Vector3.forward*speed*Time.deltaTime);
		
	}
}
