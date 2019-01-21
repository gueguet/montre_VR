using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentManager : MonoBehaviour {


    public static Classes.Operation m_CurrentOperation = null;
    public static GameObject m_CurrentPiece = null;

    public List<GameObject> m_ListPieces = new List<GameObject>();
    public static List<Classes.Operation> m_ListOpe = new List<Classes.Operation>();


    //public string[] list_schemas = new string[] { "Schema_1", "Schema_2", "Schema_3" };
    //public string[] list_operations = new string[] { "Schema_1", "Schema_2", "Schema_3" };

    //public Operation(int my_operation_number, string my_operation_name)
    //{
    //    operation_number = my_operation_number;
    //    operation_name = my_operation_name;
    //}

    //public Dictionary<string, string> dict_operations = new Dictionary<string, string>();

    //dict_operations.Add('Operation_1',"Devisser et retirer la vis de pont de balancier");

    public static int index_ope = 0;

    private void Awake()
    {
        Initialisation();
    }

    // Use this for initialization
    void Start () {


        m_CurrentOperation = m_ListOpe[index_ope];
        m_CurrentPiece = m_ListOpe[index_ope].piece;
        m_CurrentPiece.AddComponent<HighlightObject>();
        ActiveCollider();

        try
        {
            var myMesh = m_CurrentPiece.GetComponent<MeshCollider>() ;
            myMesh.enabled = true;
        }

        catch
        {

            var myMesh = m_CurrentPiece.GetComponent<CapsuleCollider>();
            myMesh.enabled = true;
        }



	}
	
	// Update is called once per frame
	void Update () {





        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("SPACEBAR");




        }



    }

    // On va créeer des objets pour chaque pièces --> devient une opération
    private void Initialisation()
    {

        int int_piece = 0;

        foreach (GameObject piece in m_ListPieces)
        {
            m_ListOpe.Add(new Classes.Operation(piece, "Retirer le pont du balancier", 1));
            int_piece += 1;
        }

    }


    public static void NextPiece()
    {
        index_ope += 1;
        m_CurrentOperation = m_ListOpe[index_ope];
        m_CurrentPiece = m_ListOpe[index_ope].piece;
        m_CurrentPiece.AddComponent<HighlightObject>();
        ActiveCollider();
        Debug.Log("current index : ");
        Debug.Log(index_ope);
    }


    public static void ActiveCollider()
    {
        try
        {
            var myMesh = m_CurrentPiece.GetComponent<MeshCollider>();
            myMesh.enabled = true;
        }

        catch
        {

            var myMesh = m_CurrentPiece.GetComponent<CapsuleCollider>();
            myMesh.enabled = true;
        }
    }



}
