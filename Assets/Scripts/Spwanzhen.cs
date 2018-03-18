using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwanzhen : MonoBehaviour {
    public GameObject zhen;
	
	void Start () {
		
	}
	
	
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(zhen, this.transform.position, Quaternion.identity);
        }
	}
}
