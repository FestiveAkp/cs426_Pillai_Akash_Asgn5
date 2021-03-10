using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    GameObject playerCamera;

    void Update()
    {
        playerCamera = GameObject.FindGameObjectWithTag("Player");
        transform.LookAt(playerCamera.transform.position, Vector3.up);
    }
}
