using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerController player;

    void Start()
    {
        Movement move = player.GetComponent<Movement>();
        Jump jump = player.GetComponent<Jump>();
        Run run = new Run();

        player.OnMove = move.Move;
        player.OnJump = jump.Jumping;
        player.OnRun = run.Running;
    }
}