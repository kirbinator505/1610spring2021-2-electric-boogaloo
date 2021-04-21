using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BulletBehavior : MonoBehaviour
{
    private Rigidbody rigidBodyObj;
    public float force = 10f;
    private Vector3 forces;
    
    public enum ForceDirections
    {
        X,Y,Z
    }

    public ForceDirections forceDirection;

    private void Awake()
    {
        rigidBodyObj = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        rigidBodyObj.WakeUp();
        
        switch (forceDirection)
        {
            case ForceDirections.X:
                forces.Set(force,0,0);
                break;
            case ForceDirections.Y:
                forces.Set(0,force,0);
                break;
            case ForceDirections.Z:
                forces.Set(0,0,force);
                break;
            default:
                forces.Set(0,0,0);
                break;
        }
        
        rigidBodyObj.AddRelativeForce(forces);
    }

    private void OnDisable()
    {
        rigidBodyObj.Sleep();
    }
}
