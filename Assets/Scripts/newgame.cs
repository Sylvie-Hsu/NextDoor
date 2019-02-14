using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class newgame : MonoBehaviour
{
    public Animator target;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        target.Play("New Animation");
        AnimatorStateInfo animatorInfo;
        animatorInfo = target.GetCurrentAnimatorStateInfo(0);
        
        // SceneManager.LoadScene("maze", LoadSceneMode.Single);
    }
    private void Update()
    {
        AnimatorStateInfo animatorInfo;
        animatorInfo = target.GetCurrentAnimatorStateInfo(0);
        if (animatorInfo.normalizedTime >= 1.0f && animatorInfo.IsName("New Animation"))
        {
            SceneManager.LoadScene("maze", LoadSceneMode.Single);
        }
    }
}

