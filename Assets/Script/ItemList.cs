using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemList : MonoBehaviour
{
    public static ItemList S;
    public int id;
    private Text task;
    // Start is called before the first frame update
    void Start()
    {
        S = this;
        task = GameObject.Find("Task").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetItem(GameObject go)
    {
        id = go.GetComponent<Task>().taskID;
        Debug.Log(id);
        if (id == 1)
        {
            task.text = "Go to find the key in other houses in current island";
        }
        else if (id == 2)
        {
            task.text = "Go to the other island to find the Treasure";
        }
    }
}
