using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bycicle : MonoBehaviour
{

    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().Bycicle();
    }
}
