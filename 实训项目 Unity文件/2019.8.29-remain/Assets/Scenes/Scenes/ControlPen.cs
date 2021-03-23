using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPen : MonoBehaviour
{
    public Text pentext;
    // Start is called before the first frame update
    void Start()
    {
        pentext.text = "Find the pen please.";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            this.gameObject.SetActive(false);
            pentext.text = "You've found it!";
        }
    }
}
