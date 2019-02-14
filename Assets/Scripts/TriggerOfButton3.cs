using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TriggerOfButton3 : MonoBehaviour
{
    public Animator target;
    public GameObject targer2;
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

        /*if (flag == false)
        {
            target.Play("New Animation");
            flag = true;
        }
        else
        {
            target.Play("New Animation1");
            flag = false;
        }*/
        target.SetTrigger("New Trigger");
        i++;
        DestroyImmediate(targer2);
        // SceneManager.LoadScene("maze", LoadSceneMode.Single);
    }
}
