using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trans : MonoBehaviour
{

    public Transform trans1;
    public Transform trans2;
    private bool Flag;
    void Start()
    {
        Flag = false;
        

    }


    // Update is called once per frame
    void Update()
    {
        if (Flag == true)
        {
            
            this.transform.parent = trans1;
            this.gameObject.GetComponent<TriggerOfDesk>().TriggerForButton();
        }
        else
        {
            this.transform.parent = trans2;
        }
    }

    public void Click()
    {
        if (Flag == false)
            Flag = true;
        else
        {
            Flag = false;
        }
    }
}
