using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Vector2 direction;
    public float speed;
    public Rigidbody2D rb;
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        rb.linearVelocity = direction * speed;
    }

    public void Move(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
        UpdateDirection(direction);
    }

    private void UpdateDirection(Vector2 move)
    {
        if (move == Vector2.zero) return;  

        int dir;
        if (Mathf.Abs(move.x) > Mathf.Abs(move.y))
            dir = move.x > 0 ? 3 : 2;       
        else
            dir = move.y > 0 ? 1 : 0;       

        animator.SetInteger("Direction", dir);
    }
}