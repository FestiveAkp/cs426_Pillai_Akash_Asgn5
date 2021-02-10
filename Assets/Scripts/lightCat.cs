using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class lightCat : MonoBehaviour
{
    public Light myLight;
    public TextMeshPro catText;
    public TextMeshPro humanText;

    void Start()
    {
        myLight = myLight.GetComponent<Light>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cat"))
        {
            print("Cat lightswitch activated");
            myLight.enabled = false;
            humanText.color = Color.red;
            catText.color = Color.green;
        }
    }
}
