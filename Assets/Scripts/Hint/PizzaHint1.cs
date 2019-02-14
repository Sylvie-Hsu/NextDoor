using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaHint1 : MonoBehaviour
{

    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().PizzaHint();
    }
}