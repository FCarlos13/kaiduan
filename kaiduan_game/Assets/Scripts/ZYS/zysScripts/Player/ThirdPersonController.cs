using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{
    private CharacterController cc;
    private Vector3 velocity;

    public float gravity = 9.8f;
    public Transform groundCheck;
    private float checkRadius = 0.4f;
    public LayerMask groundLayer;
    public bool isGround;
    static ThirdPersonController instance;
    public GameObject Camera;
    public GameObject Body;
    public GameObject CommunicateUI;
    //public GameObject CommunicateTrigger;
    public bool CommunicateTrigger = false;
    #region 角色属性状态值
    public float moveSpeed = 10f;
    public float Strength = 10f;
    public float jumpSpeed = 2f;
    private bool isAlive;
    #endregion
    #region 角色道具状态值
    public bool isGetItem1 = false;
    public bool isGetItem2 = false;
    public bool isGetItem3 = false;
    #endregion
    public static ThirdPersonController GetInstance()
    {
        return instance;
    }
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        cc = GetComponent<CharacterController>();
        isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        if (CommunicateUI.activeSelf)
        {
            Communicate();
        }
    }
    public void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        var moveDirection = transform.forward * moveSpeed * v * Time.deltaTime
            + transform.right * h * moveSpeed * Time.deltaTime;
        cc.Move(moveDirection);
        if(Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        Body.transform.forward = Vector3.Lerp(Body.transform.forward, moveDirection, 0.5f);
    }
    public void Jump()
    {
        isGround = Physics.CheckSphere(groundCheck.position, checkRadius, groundLayer);
        if (isGround && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        if (isGround && Input.GetButton("Jump"))
        {
            velocity.y = jumpSpeed;
        }
        velocity.y -= gravity * Time.deltaTime;
        cc.Move(velocity * Time.deltaTime);
    }
    public void Communicate()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            CommunicateUI.SetActive(false);
            Debug.Log("CommunicateUI为false");
            CommunicateTrigger = true;
            Debug.Log("CommunicateTrigger为true");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Communicate"|| other.tag == "可交互")
        {
            Debug.Log("接触到了可交互物体");
            CommunicateUI.SetActive(true);
            Debug.Log("CommunicateUI为true");
        }      
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Communicate")
        {
            CommunicateUI.SetActive(false);
            CommunicateTrigger = false;
        }
    }
}
