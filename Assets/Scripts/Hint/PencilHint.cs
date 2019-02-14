using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PencilHint : MonoBehaviour
{

    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().PaperHint();
    }
}
