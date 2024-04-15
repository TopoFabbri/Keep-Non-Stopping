using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float minSpeed = 5f;
    [SerializeField] private float maxSpeed = 10f;
    [SerializeField] private float minSize = 0.5f;
    [SerializeField] private float maxSize = 2f;
    [SerializeField] private Rigidbody rb;
    
    private float speed;

    private void Awake()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        transform.localScale *= Random.Range(minSize, maxSize);
    }

    private void Update()
    {
        if (transform.position.z < -10f)
            Destroy(gameObject);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -speed);
    }
}