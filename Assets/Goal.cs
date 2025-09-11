using UnityEngine;

public class Goal : MonoBehaviour
{
    public Score scoreManager;  
    public bool isPlayer1Goal;   

private void OnTriggerEnter2D(Collider2D other)
{
    Debug.Log("Hit something: " + other.name + " | Tag: " + other.tag);

    if (other.CompareTag("Ball"))
    {
        if (isPlayer1Goal)
        {
            scoreManager.PlayerScores2();
        }
        else
        {
            scoreManager.PlayerScores();
        }
    }
}
}

