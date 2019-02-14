using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Byy : MonoBehaviour
{

    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().Byy();
    }
}
