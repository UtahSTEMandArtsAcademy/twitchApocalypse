using UnityEngine;

class CameraController : MonoBehaviour 
{
    public Transform target;
    public float gumminess = 1;
    
    public Vector3 offset;
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, gumminess);
    } 
}