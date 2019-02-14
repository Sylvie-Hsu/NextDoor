using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorHint1 : MonoBehaviour
{

    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().MirrorHint();
    }
}
