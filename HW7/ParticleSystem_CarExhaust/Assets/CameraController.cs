using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

        public GameObject Car;
        private Vector3 offset;
        
	// Use this for initialization
	void Start () {
	offset = transform.position - Car.transform.position;	
	}
	
	// Update is called once per frame
	void LateUpdate () {
	transform.position = Car.transform.position + offset;	
	}
}
