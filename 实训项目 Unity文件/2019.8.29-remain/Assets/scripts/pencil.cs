using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pencil : MonoBehaviour
{
    private Animator m_walk;
    public Text text1;
    void Start()
    {
        m_walk = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            m_walk.SetBool("pencil", true);
            text1.text = "";


        }
    }
}
