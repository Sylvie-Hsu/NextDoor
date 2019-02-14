using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;
public class TriggerOfShelter : MonoBehaviour
{


    // The action to accomplish
    public Object target;                       // The game object to affect. If none, the trigger work on this game object
    public GameObject source;
    public bool repeatTrigger = false;
    public bool flag = false;




    private void OnTriggerEnter(Collider other)
    {


        Object currentTarget = target ?? gameObject;
        Behaviour targetBehaviour = currentTarget as Behaviour;
        GameObject targetGameObject = currentTarget as GameObject;
        if (targetBehaviour != null)
        {
            targetGameObject = targetBehaviour.gameObject;
        }
        if (other == source.GetComponent<Collider>())
            targetGameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        Object currentTarget = target ?? gameObject;
        Behaviour targetBehaviour = currentTarget as Behaviour;
        GameObject targetGameObject = currentTarget as GameObject;
        if (targetBehaviour != null)
        {
            targetGameObject = targetBehaviour.gameObject;
        }
        targetGameObject.SetActive(false);
    }

    public void TriggerForButton()
    {
        OnTriggerEnter(source.GetComponent<Collider>());
    }
}