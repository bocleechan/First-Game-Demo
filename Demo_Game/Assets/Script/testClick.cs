using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testClick : MonoBehaviour
{
    private Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani = gameObject.GetComponent<Animator>();
        ani.SetBool("acttack", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ani.SetBool("acttack", true);
            
        }
        if (Input.GetMouseButtonUp(0))
        {
            ani.SetBool("acttack", false);
        }
        

    }
}
