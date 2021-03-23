using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pencilMusic : MonoBehaviour
{

    public AudioSource music;
    public float musicVolume;
    // Start is called before the first frame update
    void Start()
    {
        musicVolume = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            music.Play();
        }
    }
}
