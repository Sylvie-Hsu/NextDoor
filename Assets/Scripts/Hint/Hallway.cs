using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hallway : MonoBehaviour
{

    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().Hallway();
    }
}
