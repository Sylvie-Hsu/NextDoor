using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperHint : MonoBehaviour
{

    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().PencilHint();
    }
}
