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
    private GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gm.isGameRunning)
        {
            transform.rotation = playerCam.transform.rotation;
            //Turning
            //horizontalInput = Input.GetAxis("Horizontal");

        }
        

        

        
        
    }

    private void FixedUpdate()
    {
        if(gm.isGameRunning)
        {
            verticalInput = Input.GetAxis("Vertical");
        rb.AddRelativeForce(Vector3.forward * moveSpeed * verticalInput);

        }
        
    }


}
