using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private Transform target;
    [SerializeField] private float lerpSpeed = .5f;
    [SerializeField] private Vector3 lookAtOffset;
    
    private void LateUpdate()
    {
        // transform.position = Vector3.Lerp(transform.position, target.position + offset, lerpSpeed);
        // transform.LookAt(target.position + lookAtOffset);
    }
}
