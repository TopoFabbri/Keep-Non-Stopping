using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private Vector2 direction;

    private void Update()
    {
        transform.Translate(new Vector3(direction.x, 0, direction.y) * (speed * Time.deltaTime));
    }

    public void OnMove(InputValue value)
    {
        direction = value.Get<Vector2>();
    }
}