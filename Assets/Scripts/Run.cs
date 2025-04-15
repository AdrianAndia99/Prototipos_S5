using UnityEngine;
public class Run : MonoBehaviour
{
    public float runSpeedMultiplier = 2f;
    private Movement movement;

    void Awake()
    {
        movement = GetComponent<Movement>();
    }

    public void Running()
    {
        if (movement != null)
        {
            movementSpeed();
        }
    }

    private float movementSpeed()
    {
        return 5f * runSpeedMultiplier;
    }
}