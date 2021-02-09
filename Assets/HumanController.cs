// https://gamedevacademy.org/unity-3d-first-and-third-person-view-tutorial/#Section_1_First_Person_View
// https://sharpcoderblog.com/blog/unity-3d-fps-controller

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class HumanController : NetworkBehaviour
{
    public float turnSpeed = 4.0f;
    public float moveSpeed = 2.0f;
    public float jumpForce = 30f;
    public new Camera camera;

    private float minTurnAngle = -90f;
    private float maxTurnAngle = 90f;
    private float rotationX;
    private Rigidbody rb;
    public Animation anim;
    public bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponentInChildren<Animation>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        // Jump
        if (isGrounded && Input.GetAxis("Jump") > 0)
        {
            rb.AddForce(Vector3.up * jumpForce);
        }

        // Get mouse input
        float y = Input.GetAxis("Mouse X") * turnSpeed;
        rotationX += -Input.GetAxis("Mouse Y") * turnSpeed;

        // Clamp vertical rotation and rotate camera
        rotationX = Mathf.Clamp(rotationX, minTurnAngle, maxTurnAngle);
        //camera.transform.eulerAngles = new Vector3(-rotX, transform.eulerAngles.y + y, 0);
        camera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
        transform.rotation *= Quaternion.Euler(0, y, 0);

        // Get keyboard input and move player
        Vector3 keyboardInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(keyboardInput * moveSpeed * Time.deltaTime);

        // Animate
        if (keyboardInput.x != 0 || keyboardInput.z != 0)
        {
            anim.Play();
        }
        else
        {
            anim.Stop();
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
}
