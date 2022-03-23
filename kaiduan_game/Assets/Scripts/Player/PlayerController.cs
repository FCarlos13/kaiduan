using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;

    #region ����===================================
    public float speed = 4f;
    public float gravity = 20f;
    public float JumpSpeed = 8f;
    public Vector3 velocity = Vector3.zero;
    public Animator playerAnimator;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    bool Jumping = false;
    #endregion=====================================

    void Update()
    {
        //��ȡ�����ˮƽ��ֱ��
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(horizontal, 0, vertical).normalized;
        if (!Jumping && Input.GetButton("Jump"))
        {
            velocity.y = JumpSpeed;
            Jumping = true;
        }
        if (!controller.isGrounded)
        {
            //ģ������
            velocity.y -= gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        }
        else
        {
            Jumping = false;
        }
        if (dir.magnitude >= 0.1f)   //magnitude������������
        {
            float targetAngle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg + cam.eulerAngles.y;

            //��ɫ����
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            //��ɫ�ƶ�
            Vector3 moveDir = (Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward).normalized;
            controller.Move(moveDir * speed * Time.deltaTime);

//��������============================
            playerAnimator.SetBool("isMove", true);
        }
        else
        {
            playerAnimator.SetBool("isMove", false);
        }
//====================================
    }
}
