using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour  // 전체적인 게임의 룰을 담당하는 역할을 수행
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player_1_Paddle;
    public GameObject player_1_Goal;

    [Header("Player 2")]
    public GameObject player_2_Paddle;
    public GameObject player_2_Goal;

    [Header("Score UI")]
    public Text player_1_Text;
    public Text player_2_Text;
    [Space]
    [Space]
    [Space]
    private int player_1_Score;
    private int player_2_Score;

    public void Player_1_Scored()
    {
        player_1_Score++;
        player_1_Text.text = player_1_Score.ToString();
        ResetPosition();
    }

    public void Player_2_Scored()
    {
        player_2_Score++;
        player_2_Text.text = player_2_Score.ToString();
        ResetPosition();
    }
    public void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        player_1_Paddle.GetComponent<Paddle>().Reset();
        player_2_Paddle.GetComponent<Paddle>().Reset();
    }
}
