using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private float velocidad = 5f;
    private Vector2 direccion;

    public void ReadDirection(InputAction.CallbackContext context)
    {
        direccion = context.ReadValue<Vector2>();
    }
    public void Move()
    {
        Vector3 dir = new Vector3(direccion.x, 0, direccion.y);
        transform.Translate(dir.normalized * velocidad * Time.deltaTime);
    }
}