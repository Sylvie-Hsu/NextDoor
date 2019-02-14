using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accept : MonoBehaviour
{

    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().Accept();
    }
}
