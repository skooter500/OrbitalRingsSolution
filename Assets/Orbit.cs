using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : SteeringBehaviour {

    public GameObject center;
    float radius;

    Vector3 target;

    void OnDrawGizmos()
    {
        if (Application.isPlaying)
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawLine(transform.position, target);
        }
    }

	// Use this for initialization
	void Start () {
        radius = Vector3.Distance(transform.position, center.transform.position);	
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public override Vector3 Calculate()
    {
        // Calculate a point in front of me
        // First calculate the angle Im at
        float theta = Vector3.Angle(Vector3.forward, transform.position - center.transform.position);

        // Interior or exterior
        if (transform.position.x < center.transform.position.x)
        {
            theta = (Mathf.PI * 2.0f) - theta;
        }

        theta += 10.0f;
        theta *= Mathf.Deg2Rad;
        target = new Vector3(
            center.transform.position.x + Mathf.Sin(theta) * radius
            , center.transform.position.y
            , center.transform.position.z + Mathf.Cos(theta) * radius
            );

        return target - transform.position;        
    }
}
