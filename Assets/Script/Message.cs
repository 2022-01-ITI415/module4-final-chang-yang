using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message : MonoBehaviour
{
    public static Message S;
    public int coinNum = 0;
    public int keyNum = 0;
    public GameObject coin;
    public GameObject key;
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

    public void FindKey()
    {
        keyNum++;
        key.GetComponent<Text>().text = "Key: " + keyNum.ToString() + "/1";
    }

    public void FindCoin()
    {
        coinNum++;
        coin.GetComponent<Text>().text = "Coin: " + coinNum.ToString() + "/20";
    }
}