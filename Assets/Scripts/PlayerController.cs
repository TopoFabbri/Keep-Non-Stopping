using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private Vector2 maxMove = new(2, 2);

    private Vector2 direction;

    private void Update()
    {
        transform.Translate(new Vector3(direction.x, 0, direction.y) * (speed * Time.deltaTime));
        
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, -maxMove.x, maxMove.x),
            transform.position.y, 
            Mathf.Clamp(transform.position.z, -maxMove.y, maxMove.y)
            );
    }

    public void OnMove(InputValue value)
    {
        direction = value.Get<Vector2>();
    }
}