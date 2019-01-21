using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightObject : MonoBehaviour {

    [HideInInspector]
    public Color m_OriginalColor;

    public float speedColor = 2.5f;

    float startTime;
    public bool repeatable = true;


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

        var startColor = new Color(0.317f, 0.905f, 0.964f, 0.3f);
        var endColor = new Color(0.023f, 0.031f, 0.274f, 0.3f);

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
