using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tshirt : MonoBehaviour
{

    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().Tshirt();
    }
}
