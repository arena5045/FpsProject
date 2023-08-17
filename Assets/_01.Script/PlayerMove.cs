using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10;

    CharacterController controller;
    float gravity = -20f;
    float yVelocity = 0f;
    float jumppower = 10f;
    // Start is called before the first frame update
    public bool isJumping = false;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (isJumping && controller.collisionFlags == CollisionFlags.Below)
        {
            isJumping = false;
            yVelocity = 0f;
        }
        else if (controller.collisionFlags == CollisionFlags.Below)
        {
            yVelocity = 0f;
        }

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            yVelocity = jumppower;
            isJumping = true;
        }

        //이동방향 설정
        Vector3 dir = new Vector3 (h,0,v);
        dir = Camera.main.transform.TransformDirection(dir);

        // 캐릭터 수직속도에 중력 적용
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

  

        // transform.position += dir * speed *Time.deltaTime;

        controller.Move(dir * speed * Time.deltaTime);
        
    }
}
