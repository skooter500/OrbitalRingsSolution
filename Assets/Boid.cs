﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boid : MonoBehaviour {
    List<SteeringBehaviour> behaviours = new List<SteeringBehaviour>();
    
    public Vector3 force = Vector3.zero;
    public Vector3 acceleration = Vector3.zero;
    public Vector3 velocity = Vector3.zero;
    public float mass = 1;
    public float maxSpeed = 5.0f;

    
    // Use this for initializationG
    void Start () {

        SteeringBehaviour[] behaviours = GetComponents<SteeringBehaviour>();

        foreach (SteeringBehaviour b in behaviours)
        {
            this.behaviours.Add(b);
        }
	}

    
    public Vector3 SeekForce(Vector3 target)
    {
        Vector3 desired = target - transform.position;
        desired.Normalize();
        desired *= maxSpeed;
        return desired- velocity;
    }

    public Vector3 ArriveForce(Vector3 target, float slowingDistance)
    {
        Vector3 toTarget = target - transform.position;
        float distance = toTarget.magnitude;
        float ramped = maxSpeed * (distance / slowingDistance);
        float clamped = Mathf.Min(ramped, maxSpeed);
        Vector3 desiredVelocity = clamped * (toTarget / distance);
        return desiredVelocity - velocity;
    }


    Vector3 Calculate()
    {
        force = Vector3.zero;

        foreach (SteeringBehaviour b in behaviours)
        {
            if (b.isActiveAndEnabled)
            {
                force += b.Calculate() * b.weight;
            }
        }
       return force;
    }

	
	// Update is called once per frame
	void Update () {
        force = Calculate();

        Vector3 newAcceleration = force / mass;

        float smoothRate = Mathf.Clamp(9.0f * Time.deltaTime, 0.15f, 0.4f) / 2.0f;
        acceleration = Vector3.Lerp(acceleration, newAcceleration, smoothRate);
        
        velocity += acceleration * Time.deltaTime;

        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);

        if (velocity.magnitude  > 0.0001f)
        {
            transform.LookAt(transform.position + velocity, Vector3.up);
            velocity *= 0.99f;
        }
        transform.position += velocity * Time.deltaTime;        
	}
}
