using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{

    public Ball ball;

    public TextMeshProUGUI player1Text; 
    public TextMeshProUGUI player2Text;

    private int playerScore = 0;
    private int playerScore2 = 0;

    public void PlayerScores(){
        playerScore++;
        player1Text.text = playerScore.ToString();
        ball.ResetPosition();
    }
    public void PlayerScores2(){
        playerScore2++;
        player2Text.text = playerScore2.ToString();
        this.ball.ResetPosition();
    }
    
}
