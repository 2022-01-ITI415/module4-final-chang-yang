using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message : MonoBehaviour
{
    public static Message S;
    public GameObject message;
    public GameObject task;

    // Start is called before the first frame update
    void Start()
    {
        S = this;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.C))
        {
            message.SetActive(false);
        }
    }

    public void WinMessage()
    {
        message.SetActive(true);
        task.SetActive(false);
    }
}