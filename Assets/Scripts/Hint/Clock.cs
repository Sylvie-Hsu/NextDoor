using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{

    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().Clock();
    }
}
