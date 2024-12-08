using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1;
    // �浹 ���� ���� �Լ�
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Ball"))
        {
            if (isPlayer1.Equals(false)) //player_2_Goal�ΰ�? 
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().Player_1_Scored();
            }
            else // true== player_1_Goal �̾�?
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().Player_2_Scored();
            }
        }

    }

}
// �浹�� ���� isPlayer1 �� �� ��, Player_1_Goal ������Ʈ�ΰ�?

//������ ����

//Ʋ���� ����
//collider ��� ������Ʈ�� �־�� �浹�˻簡 ����
//Collider �� 2���� ��Ȳ�� ����
//1. isTrigger�� �������� �� �浹 �����Լ�
// - OnTriggerEnter
// - OnTriggerStay
// - OnTriggerExit
//2. isTrigger�� ���� ���� �� �浹 ���� �Լ�
// - OnCollisionEnter
// - OnCollisionStay
// - OnCollisionExit