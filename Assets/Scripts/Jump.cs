using UnityEngine;
public class Jump : MonoBehaviour
{
    private Rigidbody rb;
    private float jumpForce = 7f;
    private bool canJump = true;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Jumping()
    {
        if (canJump)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            canJump = false;
            Debug.Log("¡Salto con fuerza!");
        }
    }
    public void AllowJump()
    {
        canJump = true;
    }
}