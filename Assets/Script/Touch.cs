using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    private Material oldColor;
    public Material newColor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            oldColor = other.GetComponent<MeshRenderer>().material;
            Transform[] tc = other.GetComponentsInChildren<Transform>();
            for (int i = 0; i < tc.Length; i++)
            {
                tc[i].GetComponent<MeshRenderer>().material = newColor;
            }
            
            other.GetComponent<MeshRenderer>().material = newColor;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Item")
        {
            if (Input.GetKey(KeyCode.E))
            {
                ItemList.S.GetItem(other.gameObject);
                other.gameObject.SetActive(false);
            }
        }
        else if (other.tag == "Chest")
        {
            if (Input.GetKey(KeyCode.E))
            {
                if (ItemList.S.key == true)
                {
                    other.GetComponent<Chest>().OpenChest();
                }
                else if (ItemList.S.key == false)
                {
                    Debug.Log("no key");
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Item")
        {
            Transform[] tc = other.GetComponentsInChildren<Transform>();
            for (int i = 0; i < tc.Length; i++)
            {
                tc[i].GetComponent<MeshRenderer>().material = oldColor;
            }
            other.GetComponent<MeshRenderer>().material = oldColor;
        }
    }
}
