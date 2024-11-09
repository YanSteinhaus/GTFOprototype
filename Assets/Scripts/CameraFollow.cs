using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 offset = new Vector3(0f,5f,-10f);
    private float smoothSpeed = 0.0125f;

    [HideInInspector]
    public Transform target;

    private Vector3 targetPosition;

    
    private void LateUpdate()
    {
        if (target != null)
        {
            targetPosition = target.position + offset;

            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);
        }
    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

   
}
