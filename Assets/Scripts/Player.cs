using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float walkspeed;
    public float runspeed;
    public float jumpSpeed;
    public float gravity;
    public Animator ani;
    private Vector3 moveDirection = Vector3.zero;
    float speed;
    CharacterController controller;
    
    public
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        
    }
    public void OpenDoor0()
    {
        GameObject door0 = GameObject.Find("0").gameObject;
        if(Vector3.Distance(transform.position,door0.transform.position)<1)
        {
            door0.GetComponent<Animation>().Play("Open0");  
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {
            //ªÒ»°wasd
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump")) moveDirection.y = jumpSpeed;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);



        if (Input.GetMouseButton(1))
        {
            transform.Rotate(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A))
        {
            ani.SetBool("isMove", true);

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    speed = runspeed;
                    ani.SetFloat("walkrun", 0.9f);
                }
                else
                {
                    speed = walkspeed;
                    ani.SetFloat("walkrun", 0.3f);
                }
                }

            
        }
        else ani.SetBool("isMove", false);

        if (Input.GetKeyDown(KeyCode.Space)) ani.SetTrigger("jump");

    }
}