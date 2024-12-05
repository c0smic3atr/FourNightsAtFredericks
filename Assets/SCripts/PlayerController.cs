using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    public GameObject playerCam;

    [Header("Movement")]
    private float verticalInput;
    private float horizontalInput;
    public float moveSpeed;
    public float turnSpeed;
    public bool isGameActive = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = playerCam.transform.rotation;

        //Moving
        //verticalInput = Input.GetAxis("Vertical");
       // rb.AddRelativeForce(Vector3.forward * moveSpeed * verticalInput);

        //Turning
        horizontalInput = Input.GetAxis("Horizontal");
        //transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        
        verticalInput = Input.GetAxis("Vertical");
        rb.AddRelativeForce(Vector3.forward * moveSpeed * verticalInput);
    }


}
