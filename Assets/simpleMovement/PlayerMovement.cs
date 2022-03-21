using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        
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
        //transform.Translate(movementDirection * speed * Time.deltaTime);
        transform.position += movementDirection * speed * Time.deltaTime;

    }
}
