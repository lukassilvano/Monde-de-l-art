/*
using UnityEngine;
using System.Collections;

public class PlayerWalk : MonoBehaviour
{
    public float speed = 10f;
    public float jumpForce = 8f;
    public float gravity = 30f;
    public Vector3 moveDir = Vector3.zero;
    private CharacterController controller;

    public float movementSpeed = 10;
    public float turningSpeed = 60;
    private float verticalVelocity;

    void Start()
    {

    }

    void Update()
    {
        CharacterController controller = gameObject.GetComponent<CharacterController>();

        if (controller.isGrounded)
        {
            float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
            transform.Rotate(0, horizontal, 0);

            float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
            transform.Translate(0, 0, -vertical);

            moveDir = new Vector3(0, 0, -vertical);

            moveDir = transform.TransformDirection(moveDir);

            moveDir *= speed;

            if (Input.GetButtonDown("Jump"))
            {
                moveDir.y = jumpForce * speed;
            }
        }


        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);

    }
}
*/
/*
using UnityEngine;
using System.Collections;

public class PlayerWalk : MonoBehaviour
{

    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;

    private Vector3 moveDirection = Vector3.back;
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            controller.Move(Vector3.back * Time.deltaTime);
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
*/
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public float walkSpeed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private float rotateSpeed = 50f;

    private Vector3 moveDirection = Vector3.zero, moveDirectionController = Vector3.zero;
    private CharacterController controller;

    private Vector3 mousePos, rightAxis;
    private float lastAngle;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(-Input.GetAxis("Horizontal"), 0, -Input.GetAxis("Vertical"));
            moveDirectionController = new Vector3(-Input.GetAxis("Left Analog Horizontal"), 0, -Input.GetAxis("Left Analog Vertical"));
            //moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= walkSpeed;
            moveDirectionController *= walkSpeed;
            /*if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
                */
            
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        moveDirectionController.y -= gravity * Time.deltaTime;
        controller.Move(moveDirectionController * Time.deltaTime);


        //Mira pelo mouse
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward * 40f);
        transform.LookAt(new Vector3(mousePos.x, transform.position.y, mousePos.z));

        //Mira pelo controle
        float x = Input.GetAxis("Right Analog Horizontal");
        float y = Input.GetAxis("Right Analog Vertical");
        float aim_angle = 0.0f;

        // CANCEL ALL INPUT BELOW THIS FLOAT
        float R_analog_threshold = 0.20f;

        if (Mathf.Abs(x) < R_analog_threshold) { x = 0.0f; }

        if (Mathf.Abs(y) < R_analog_threshold) { y = 0.0f; }

        // CALCULATE ANGLE AND ROTATE
        if (x != 0.0f || y != 0.0f)
        {

            aim_angle = Mathf.Atan2(y, x) * Mathf.Rad2Deg;

            // ANGLE GUN
            transform.rotation = Quaternion.AngleAxis(aim_angle, Vector3.up);
        }
    }
}