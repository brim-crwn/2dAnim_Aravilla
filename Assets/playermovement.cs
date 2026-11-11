using UnityEngine;
using UnityEngine.InputSystem;


public class playermovement : MonoBehaviour
{
    public float moveSpeed;
    private Animator Animator;
    private Vector2 movement;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();

    }

    void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        if(movement != Vector2.zero)
        {
            Animator.SetFloat("LoopX",movement.x);
            Animator.SetFloat("LoopY",movement.y);
        }
    }
}
