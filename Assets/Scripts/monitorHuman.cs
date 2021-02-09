using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monitorHuman : MonoBehaviour
{
    public GameObject monitor;

    void Start()
    {
        //monitor = monitor.GetComponent<GameObject>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("Human monitor switch activated");
            monitor.SetActive(true);
        }
    }
}
