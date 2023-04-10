using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_1 : MonoBehaviour
{
    CharacterController controller_1;
    Vector3 velocity_1;
    bool isGrounded_1;

    public Transform ground;
    public float distance = 0.3f;

    public float speed;
    public float jumpHeight;
    public float gravity;
    public LayerMask mask;

    private void Start()
    {
        controller_1 = GetComponent<CharacterController>();
    }

    private void Update()
    {
        #region Movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = transform.right * horizontal + transform.forward * vertical;
        controller_1.Move(move * speed * Time.deltaTime);
        #endregion


        #region Jump

        if( Input.GetKeyDown(KeyCode.Space) && isGrounded_1 )
        {
            velocity_1.y += Mathf.Sqrt(jumpHeight * -3.0f * gravity);
        }



        #endregion

        #region Gravity

        isGrounded_1 = Physics.CheckSphere(ground.position, distance, mask);
        if(isGrounded_1 && velocity_1.y < 0)
        {
            velocity_1.y = 0f;
        }
        velocity_1.y += gravity * Time.deltaTime;
        controller_1.Move(velocity_1 * Time.deltaTime);
        #endregion


    }






}

