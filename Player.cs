using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SkillData;



public class Player : MonoBehaviour
{
    public float speed = 5f;
    public float clockwise = 100.0f;
    public float counterClockwise = -100.0f;

    public Animator animator_Beast;
    public Animator animator_Hero;
    Rigidbody rigid;

    float hAxis;
    float vAxis;
    bool jDown;
    bool isJump = false;

    public Vector3 moveVec;

    // Start is called before the first frame update
    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }
    void Start()
    {
        Debug.Log(gameObject.transform.childCount.ToString());
        Debug.Log(gameObject.transform.GetChild(0).name.ToString());
        Debug.Log(gameObject.transform.GetChild(1).name.ToString());

        //animator = gameObject.transform.GetChild(1).gameObject.GetComponent<Animator>();
        Invoke("animatorSetting", 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("Player").transform.GetChild(3).GetComponent<Stage_Beast>().Attacking) { 
        GetInput();
        Move();
        Turn();
        Jump();
        }
    }

    /*void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            animator.Play("Turn Left");
            transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y - 90, transform.rotation.z));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.Play("Turn Right");
            //transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y + 90, transform.rotation.z));
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }
    }*/
    void GetInput() // 키보드 값 받기
    {
        hAxis = Input.GetAxisRaw("Horizontal"); // a , d
        vAxis = Input.GetAxisRaw("Vertical"); // w , s
        jDown = Input.GetButton("Jump");
    }

    void Move()
    {
        /*moveVec = new Vector3(-vAxis, 0, hAxis).normalized;
        transform.position += moveVec * speed * Time.deltaTime;
        animator_Hero.SetBool("isWalk", moveVec != Vector3.zero); // Walk 애니메이션 true
        animator_Beast.SetBool("isWalk", moveVec != Vector3.zero); // Walk 애니메이션 true*/
        //animator.Play("Walk");
        
        moveVec = new Vector3(-vAxis, 0, hAxis).normalized;
        if (Input.GetKey(KeyCode.W))
        {
            //transform.position += Vector3.forward * Time.deltaTime * speed;
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            //transform.position -= Vector3.forward * Time.deltaTime * speed;
            transform.Translate( -Vector3.forward * Time.deltaTime * speed);
            
        }
        else if (Input.GetKey(KeyCode.A))
        {
            //transform.position -= Vector3.right * Time.deltaTime * speed;
            transform.Translate( -Vector3.right * Time.deltaTime * speed);

        }
        else if (Input.GetKey(KeyCode.D))
        {
            //transform.position += Vector3.right * Time.deltaTime * speed;
            transform.Translate(Vector3.right * Time.deltaTime * speed);

        }

        animator_Hero.SetBool("isWalk", moveVec != Vector3.zero); // Walk 애니메이션 true
        animator_Beast.SetBool("isWalk", moveVec != Vector3.zero); // Walk 애니메이션 true*/
    }

    void Turn()
    {
        //transform.LookAt(transform.position + moveVec); // 자연스럽게 회전
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, Time.deltaTime * clockwise, 0);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -Time.deltaTime * clockwise, 0);
        }
    }

    void Jump()
    {
        // Jump하고 있는 상황에서 Jump 하지 않도록 방지
        if (jDown && !isJump)
        {
            rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
            animator_Beast.SetTrigger("doJump"); // Jump Trigger true 설정
            isJump = true;
        }
    }

    void animatorSetting()
    {
        animator_Beast = GameObject.Find("Player").transform.GetChild(3).GetComponent<Animator>();
        animator_Hero = GameObject.Find("Player").transform.GetChild(2).GetComponent<Animator>();
    }

    public void SkillUse_1()
    {

    }
    public void SkillUse_2()
    {

    }
    public void SkillUse_3()
    {

    }
    public void SkillUse_4()
    {

    }
}
