using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoodleTong : MonoBehaviour
{

    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().NoodleTong();
    }
}
