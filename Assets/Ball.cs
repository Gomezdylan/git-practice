using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float startingSpeed;

    void Start()
    {
        LaunchBall();
    }

    // This will reset ball position to center and launch it again
    public void ResetPosition()
    {
        rb.linearVelocity = Vector2.zero;   // stop movement
        transform.position = Vector2.zero;  // move back to center
        LaunchBall();                       // relaunch
    }

    private void LaunchBall()
    {
        bool isRight = UnityEngine.Random.value >= 0.5f;
        float xVelocity = isRight ? 1f : -1f;
        float yVelocity = UnityEngine.Random.Range(-1f, 1f);

        rb.linearVelocity = new Vector2(xVelocity * startingSpeed, yVelocity * startingSpeed);
    }
}
