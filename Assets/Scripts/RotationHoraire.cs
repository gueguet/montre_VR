using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationHoraire : MonoBehaviour {

    public float m_RotationSpeed = 50.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
            transform.Rotate(0, m_RotationSpeed * Time.deltaTime, 0);

    }
}
