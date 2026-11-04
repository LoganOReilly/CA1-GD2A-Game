using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerControl : MonoBehaviour
{
    public int speed = 5;
    private Vector2 move;
    private Rigidbody2D rb;
    private Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        move = InputSystem.actions["Move"].ReadValue<Vector2>();
        Vector2 position = transform.position;
        position.x += (move.x * speed) * Time.fixedDeltaTime;
        position.y += (move.y * speed) * Time.fixedDeltaTime;
        rb.transform.position = position;
        animator.SetFloat("DirX", move.x);
        animator.SetFloat("DirY", move.y);
        if (move.x != 0 || move.y != 0)
        {
            animator.SetBool("Move", true);
        }
        else
        {
            animator.SetBool("Move", false);
        }
    }
}
