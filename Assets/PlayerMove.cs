using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10f; //스피드 변수 선언
    public float rotSpeed = 10f; // 회전스피드 변수 선언
    Rigidbody playerRd; // 리지드 타입 변수 선언
    Vector3 dir = Vector3.zero; // Vector3 타입 변수 선언 및 대입. Vector3.zero는 (0.0.0)
    // Start is called before the first frame update
    void Start()
    {
        playerRd = GetComponent<Rigidbody>(); // 리지드 바디 컴포넌트 가져오기
    }

    // Update is called once per frame
    void Update()
    {
        dir.x = Input.GetAxis("Horizontal"); // 수평축 방향을 입력받아 dir.x에 대입
        dir.z = Input.GetAxis("Vertical"); // 수직축 방향을 입력받아 dir.z에 대입
        dir = dir.normalized; // 방향 벡터를 정규화하여 이동속도를 일정하게 유지
    }
    
    private void FixedUpdate()
    {
        if (dir != Vector3.zero)
        {
            if (Mathf.Sign(transform.forward.x) != Mathf.Sign(dir.x) || Mathf.Sign(transform.forward.z) != Mathf.Sign(dir.z))
            {
                transform.Rotate(0, 1, 0);
            }
            // transform.forward = dir; transform.foward는 전방방향(z축)을 뜻하는 속성 dir 뱐수를 대입 
            transform.forward = Vector3.Lerp(transform.forward, dir , rotSpeed * Time.deltaTime);
        }
        playerRd.MovePosition(this.gameObject.transform.position + dir * speed * Time.deltaTime);
    }
}
