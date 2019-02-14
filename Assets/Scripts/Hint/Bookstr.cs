using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bookstr : MonoBehaviour
{

    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().Bookstr();
    }
}
