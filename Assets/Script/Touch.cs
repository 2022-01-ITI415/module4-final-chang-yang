using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    private Material oldColor;
    public Material newColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            Debug.Log("1");
            oldColor = other.GetComponent<MeshRenderer>().material;
            other.GetComponent<MeshRenderer>().material = newColor;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Item")
        {
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("2");
                other.gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Item")
        {
            Debug.Log("3");
            other.GetComponent<MeshRenderer>().material = oldColor;
        }
    }
}
