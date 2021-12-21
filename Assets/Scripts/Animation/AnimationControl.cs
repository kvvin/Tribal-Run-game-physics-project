using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    public GameObject man;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            man.GetComponent<Animator>().Play("Jump");
        }
    }
}
