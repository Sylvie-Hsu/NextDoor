using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loli : MonoBehaviour
{

    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().Loli();
    }
}
