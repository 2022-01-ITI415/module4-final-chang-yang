using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public static Chest S;
    public GameObject chestCover;
    Animator mAnimator;
    // Start is called before the first frame update
    void Start()
    {
        S = this;
        mAnimator = chestCover.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenChest()
    {
        mAnimator.SetTrigger("TrOpen");
    }
}
