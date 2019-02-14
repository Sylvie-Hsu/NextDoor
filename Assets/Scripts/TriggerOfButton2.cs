using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TriggerOfButton2 : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    public int i = 1;
    public bool flag = false;

    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        DestroyImmediate(target);
        this.gameObject.SetActive(false);
    }
}
