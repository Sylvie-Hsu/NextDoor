using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paper2 : MonoBehaviour
{

    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().Paper2();
    }
}
