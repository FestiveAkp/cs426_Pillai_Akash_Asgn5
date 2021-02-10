using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class monitorHuman : MonoBehaviour
{
    public GameObject monitor;
    public TextMeshPro text;

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
            text.color = Color.green;
        }
    }
}
