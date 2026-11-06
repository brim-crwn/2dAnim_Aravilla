using UnityEngine;

public class TEstDummy : MonoBehaviour
{
    public int health = 100;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("MeleeAttack"))
        {
            Debug.Log("YOWCH!" + " Health:" + health);
            health-= 5;
        }
    }
}
