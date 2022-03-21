using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float rotationSpeed;
    private CharacterController characterController;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        //if(horizontalInput != 0)
        //    Debug.Log("Horizontal Input" + horizontalInput);

        //if (verticalInput != 0)
        //    Debug.Log("Vertical Input" + verticalInput);

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        movementDirection.Normalize();

        characterController.SimpleMove(movementDirection * speed);

        //transform.Translate(movementDirection * speed * Time.deltaTime,Space.World);// let give it to character Controller;
        //transform.position += movementDirection * speed * Time.deltaTime;
        if(movementDirection != Vector3.zero)
        {
            //transform.forward = movementDirection;
            Quaternion toRotation = Quaternion.LookRotation(movementDirection,Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            //Debug.Log(toRotation);
        }

    }
}
