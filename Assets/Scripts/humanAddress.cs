using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humanAddress : MonoBehaviour
{
    public Renderer address;

    void Start()
    {
        address = GetComponent<Renderer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cat"))
        {
            print("Human address switch activated");
            address.material.color = Color.green;
            //monitor.SetActive(false);
        }
    }
}
