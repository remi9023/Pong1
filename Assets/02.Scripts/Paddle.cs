using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1; // 참이면 플레이어 1의 패들이 움직이고 아니면 2가 움직이는 것
    public float speed; 
    public Rigidbody2D rb;

    private float movement; // 방향에 대한 변수

    public Vector3 startPosition;
    
    // 유니티에서는 물체를 움직이는 방법이 여러가지 있다.
    // 1, 첫번째 방법 - rigidbody를 활용한 방법(물리력)
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // 애초에 리짓바디를 코드에서부터 붙여주는 것
        startPosition = transform.position;
    }
    
    void Update()
    {
        if (isPlayer1) // Player1 오브젝트 움직임의 방향 정하기
        {
            movement = Input.GetAxisRaw("Vertical"); // GetAxis와의 차이는 빠딱빠딱하게 움직일 필요가 있을때는 Raw를 활용
                                                    // 부드러운 이동이 필요한 때에는 그냥 GetAxis
        }
        else  // Player2 오브젝트 움직임
        {
            movement = Input.GetAxisRaw("Vertical2");
        }
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    public void Reset()  // 초기화 함수
    {
        rb.velocity = Vector2.zero; // 움직이고 있다면 속도를 0으로 초기화
        transform.position = startPosition; // 현재 나의 위치를 초기값으로 세팅
    }
}
