using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChipsHint1 : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.ChipsHint();
    }
}
