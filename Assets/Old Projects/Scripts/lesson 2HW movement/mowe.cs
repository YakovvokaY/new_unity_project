using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mowe : MonoBehaviour
{
    public float speed;
    public float Jumpforse;
    private Rigidbody rb;

    [SerializeField] Transform CamTrans;

    private float mouseX;
    private float mouseY;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Physics.Raycast(transform.position, Vector3.down , 1.8f))
            {
                Jump();
            }
        }  
    }

    void FixedUpdate()
    {
        mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * 400;
        mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * 400;

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * speed;
        }
        transform.Rotate(mouseX * new Vector3(0, 1, 0));
        CamTrans.Rotate(-mouseY * new Vector3(1, 0, 0));
    }
    void Jump()
    {
        Vector3 forse = Vector3.up * Jumpforse;
        rb.AddForce(forse, ForceMode.Acceleration);
    }
}
