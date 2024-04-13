using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float shakeRange = .2f;
    [SerializeField] private float shakeSpeed = .1f;

    private Vector3 pos;
    private Vector3 targetPos;

    private void Awake()
    {
        pos = transform.position;
        targetPos = pos;
    }

    private void LateUpdate()
    {
        if (transform.position != targetPos)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, shakeSpeed);
        }
        else
        {
            targetPos.y = Mathf.Lerp(pos.y - shakeRange, pos.y + shakeRange, Random.value);
            targetPos.x = Mathf.Lerp(pos.x - shakeRange, pos.x + shakeRange, Random.value);
        }
    }
}