using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
        Init(); // 여기다가 넣는 이유? : 게임을 시작할 때 실행되니까 랜덤 변수로 시작을 해야하니까 스타트 함수에 넣음
    }

    // Update is called once per frame

    public void Reset()
    {
        rb.velocity = Vector3.zero;
        transform.position = startPosition;
        Init(); // 리셋에 넣는 이유 처음으로 돌아와도 다시 랜덤 함수의 값을 가져야 하므로 랜덤함수에 넣음
    }
    private void Init()  // 1,2,3,4 방향중에 1가지 방향으로 날아가게 하는 함수 랜덤 함수
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1; //삼항연산자 0인지 확인하고 맞으면 -1 대입 아니면 1 대입 조건식 ? 참일경우 반환값 1 : 거짓일경우 반환값 2
                                                    //int 타입으로 숫자뽑는거랑 float 타입이랑 숫자뽑는 인식 범위가 다르다.

        float y = Random.Range(0, 2) == 0 ? -1 : 1; 

        rb.velocity = new Vector2 (x * moveSpeed, y * moveSpeed);   
    }
  
       
}
