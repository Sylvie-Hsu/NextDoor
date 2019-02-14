using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TriggerOfButton : MonoBehaviour
{
    public Animator target;
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
        // SceneManager.LoadScene("maze", LoadSceneMode.Single);
    }
}
