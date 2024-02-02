using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SceneController : MonoBehaviour
{
    [SerializeField] Animator machine;
    [SerializeField] GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        // machine.enabled = true;
    }

    public void PlayAnimation()
    {
      //  machine.enabled = true;
        text.SetActive(true);
    }
}
