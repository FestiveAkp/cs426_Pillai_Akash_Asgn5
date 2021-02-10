using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class monitorCat : MonoBehaviour
{
    public GameObject monitor;
    public TextMeshPro catText;
    public TextMeshPro humanText;

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
            catText.color = Color.green;
            humanText.color = Color.red;
        }
    }
}
