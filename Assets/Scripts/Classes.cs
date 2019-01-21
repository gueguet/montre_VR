using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes : MonoBehaviour {


    public class Operation
    {
        //public int number_operation;
        public GameObject piece;
        public string description;
        public int number_schema;

        public Operation(GameObject my_piece, string my_description, int n_schema)
        {
            //number_operation = n_ope;
            piece = my_piece;
            description = my_description;
            number_schema = n_schema;
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
