using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public LayerMask groundLayer;
    private float horizontal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void Move (InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<Vector2>().x ;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocity= new Vector2(horizontal * speed, rb.linearVelocity.y);
    }
}
