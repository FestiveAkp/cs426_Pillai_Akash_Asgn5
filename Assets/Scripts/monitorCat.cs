using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monitorCat : MonoBehaviour
{
    public GameObject monitor;

    void Start()
    {
        //monitor = monitor.GetComponent<GameObject>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cat"))
        {
            print("Cat monitor switch activated");
            monitor.SetActive(false);
        }
    }
}
