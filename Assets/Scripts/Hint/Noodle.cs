using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noodle : MonoBehaviour
{

    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().Noodle();
    }
}
