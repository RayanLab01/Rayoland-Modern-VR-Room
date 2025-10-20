using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPauseMusic : MonoBehaviour
{
    private AudioSource audioSource = null;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    

    public void TogglePlayPause()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
        }
        else
            audioSource.Play();
    }

}
