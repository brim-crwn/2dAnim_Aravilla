using UnityEngine;

public class Player_Attack_Controller : MonoBehaviour
{
    private Animator animator;
    public Collider2D meleeHitbox;

    void Start()
    {
        animator = GetComponent<Animator>();
        meleeHitbox.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Melee");
        }
    }

    public void EnableMeleeHitBox()
    {
        meleeHitbox.enabled = true;
    }

    public void DisableMeleeHitBox()
    {
        meleeHitbox.enabled = false;

    }
}
