using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1; // ���̸� �÷��̾� 1�� �е��� �����̰� �ƴϸ� 2�� �����̴� ��
    public float speed; 
    public Rigidbody2D rb;

    private float movement; // ���⿡ ���� ����

    public Vector3 startPosition;
    
    // ����Ƽ������ ��ü�� �����̴� ����� �������� �ִ�.
    // 1, ù��° ��� - rigidbody�� Ȱ���� ���(������)
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // ���ʿ� �����ٵ� �ڵ忡������ �ٿ��ִ� ��
        startPosition = transform.position;
    }
    
    void Update()
    {
        if (isPlayer1) // Player1 ������Ʈ �������� ���� ���ϱ�
        {
            movement = Input.GetAxisRaw("Vertical"); // GetAxis���� ���̴� ���������ϰ� ������ �ʿ䰡 �������� Raw�� Ȱ��
                                                    // �ε巯�� �̵��� �ʿ��� ������ �׳� GetAxis
        }
        else  // Player2 ������Ʈ ������
        {
            movement = Input.GetAxisRaw("Vertical2");
        }
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    public void Reset()  // �ʱ�ȭ �Լ�
    {
        rb.velocity = Vector2.zero; // �����̰� �ִٸ� �ӵ��� 0���� �ʱ�ȭ
        transform.position = startPosition; // ���� ���� ��ġ�� �ʱⰪ���� ����
    }
}
