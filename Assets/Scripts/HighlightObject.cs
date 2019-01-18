using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightObject : MonoBehaviour {

    [HideInInspector]
    public Color m_OriginalColor;

    public float speedColor = 1.0f;
    private Color startColor = new Color(116, 240, 243);
    private Color endColor = new Color(17, 42, 63);
    float startTime;
    public bool repeatable = false;


    private void Awake()
    {
        m_OriginalColor = transform.GetComponent<Renderer>().material.color;
    }

    // Use this for initialization
    void Start () {

        startTime = Time.time;



    }
	
	// Update is called once per frame
	void Update () {
        if (!repeatable)
        {
            float t = (Time.time - startTime) * speedColor;
            GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, t);
        }

        else
        {
            float t = Mathf.Sin((Time.time - startTime) * speedColor);
            GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, t);
        }

		
	}
}
