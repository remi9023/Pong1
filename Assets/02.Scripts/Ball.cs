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
        Init(); // ����ٰ� �ִ� ����? : ������ ������ �� ����Ǵϱ� ���� ������ ������ �ؾ��ϴϱ� ��ŸƮ �Լ��� ����
    }

    // Update is called once per frame

    public void Reset()
    {
        rb.velocity = Vector3.zero;
        transform.position = startPosition;
        Init(); // ���¿� �ִ� ���� ó������ ���ƿ͵� �ٽ� ���� �Լ��� ���� ������ �ϹǷ� �����Լ��� ����
    }
    private void Init()  // 1,2,3,4 �����߿� 1���� �������� ���ư��� �ϴ� �Լ� ���� �Լ�
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1; //���׿����� 0���� Ȯ���ϰ� ������ -1 ���� �ƴϸ� 1 ���� ���ǽ� ? ���ϰ�� ��ȯ�� 1 : �����ϰ�� ��ȯ�� 2
                                                    //int Ÿ������ ���ڻ̴°Ŷ� float Ÿ���̶� ���ڻ̴� �ν� ������ �ٸ���.

        float y = Random.Range(0, 2) == 0 ? -1 : 1; 

        rb.velocity = new Vector2 (x * moveSpeed, y * moveSpeed);   
    }
  
       
}
