using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public Paddle playerPaddle;
    public Paddle adversaryPaddle;

    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI adversaryScoreText;

    private int _playerScore;
    private int _adversaryScore;

    public void PlayerScores()
    {
        _playerScore++;
        playerScoreText.text = _playerScore.ToString();
        ResetRound();
    }

    public void AdversaryScore()
    {
        _adversaryScore++;
        adversaryScoreText.text = _adversaryScore.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        playerPaddle.ResetPosition();
        adversaryPaddle.ResetPosition();
        ball.ResetPosition();
        ball.AddStartingForce();
    }
}
