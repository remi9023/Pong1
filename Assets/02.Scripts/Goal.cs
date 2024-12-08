using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1;
    // 충돌 여부 판정 함수
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Ball"))
        {
            if (isPlayer1.Equals(false)) //player_2_Goal인가? 
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().Player_1_Scored();
            }
            else // true== player_1_Goal 이야?
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().Player_2_Scored();
            }
        }

    }

}
// 충돌한 곳이 isPlayer1 이 참 즉, Player_1_Goal 오브젝트인가?

//맞으면 여기

//틀리면 여기
//collider 라는 컴포넌트가 있어야 충돌검사가 가능
//Collider 는 2가지 상황이 있음
//1. isTrigger가 켜져있을 때 충돌 검출함수
// - OnTriggerEnter
// - OnTriggerStay
// - OnTriggerExit
//2. isTrigger가 꺼져 있을 때 충돌 검출 함수
// - OnCollisionEnter
// - OnCollisionStay
// - OnCollisionExit