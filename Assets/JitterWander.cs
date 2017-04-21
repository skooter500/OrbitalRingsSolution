using System.Collections.Generic;
using UnityEngine;

public class JitterWander: SteeringBehaviour
{
    [Range(0.0f, 100.0f)]
    public float radius = 10.0f;

    [Range(0.0f, 1000.0f)]
    public float jitter = 5.0f;

    [Range(0.0f, 100.0f)]
    public float distance = 15.0f;

    private Vector3 target;

    public void OnDrawGizmos()
    {
        if (isActiveAndEnabled)
        {
            Gizmos.color = Color.blue;
            Vector3 wanderCircleCenter = transform.TransformPoint(Vector3.forward*distance);
            Gizmos.DrawWireSphere(wanderCircleCenter, radius);
            Gizmos.color = Color.gray;
            Vector3 worldTarget = transform.TransformPoint(target + Vector3.forward*distance);
            Gizmos.DrawLine(transform.position, worldTarget);
        }
    }

    public void Start()
    {
        target = Random.insideUnitSphere * radius;
    }

    public override Vector3 Calculate()
    {
        float jitterTimeSlice = jitter * Time.deltaTime;

        Vector3 toAdd = Random.insideUnitSphere * jitterTimeSlice;
        target += toAdd;
        target.Normalize();
        target *= radius;

        Vector3 localTarget = target + Vector3.forward * distance;
        Vector3 worldTarget = transform.TransformPoint(localTarget);
        return (worldTarget - transform.position);
    }
}