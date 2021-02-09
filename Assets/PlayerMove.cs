// https://forum.unity.com/threads/move-character-in-the-direction-of-camera.634429/#post-4251334
// https://answers.unity.com/questions/803365/make-the-player-face-his-movement-direction.html
// https://answers.unity.com/questions/1616825/how-can-i-stop-player-snapping-back-to-000-rotatio.html

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerMove : NetworkBehaviour
{
    public float moveSpeed = 7.5f;
    public float jumpForce = 30f;

    // Camera
    public float turnSpeed = 4.0f;
    public new Camera camera;
    private float targetDistance;
    private float rotX;

    // Player model used for rotation
    public GameObject model;

    private Rigidbody rb;
    public bool isGrounded = false;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        Cursor.lockState = CursorLockMode.Locked;
        targetDistance = Vector3.Distance(camera.transform.position, gameObject.transform.position + new Vector3(0, 10, 0));
    }

    void Update()
    {
        if (!isLocalPlayer) 
        {
            camera.enabled = false;
        }

        camera.enabled = true;

        // Jump
        if (isGrounded && Input.GetAxis("Jump") > 0)
        {
            rb.AddForce(Vector3.up * jumpForce);
        }

        // Get mouse inputs
        float y = Input.GetAxis("Mouse X") * turnSpeed;
        rotX += Input.GetAxis("Mouse Y") * turnSpeed;
        rotX = Mathf.Clamp(rotX, -90f, 0.0f);

        // Rotate and move the camera
        camera.transform.eulerAngles = new Vector3(-rotX, camera.transform.eulerAngles.y + y, 0);
        camera.transform.position = gameObject.transform.position - (camera.transform.forward * targetDistance);

        // Get movement input
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        Vector3 moveInput = new Vector3(moveX, 0, moveZ);

        // Move forward relative to where the camera is looking
        Vector3 moveDirection = Quaternion.Euler(0, camera.transform.eulerAngles.y, 0) * moveInput;        
        transform.Translate(moveDirection, Space.World);

        // Rotate the player model relative to movement
        if (moveX != 0 || moveZ != 0)
        {
            Quaternion modelRotation = Quaternion.LookRotation(moveDirection);
            float rotationSpeed = 0.05f;
            model.transform.rotation = Quaternion.Slerp(model.transform.rotation, modelRotation, rotationSpeed);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground") 
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground") 
        {
            isGrounded = false;
        }
    }

    public override void OnStartLocalPlayer()
    {
        
    }
}
