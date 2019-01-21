using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceDetection : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {



        if (col.transform.tag == "Interactable")
        {
            Debug.Log("COLLISION CHEF");
            Debug.Log(col.transform.name);

            Destroy(col.transform.GetComponent<Interactable>());

            ComponentManager.NextPiece();


        }

    }

}
