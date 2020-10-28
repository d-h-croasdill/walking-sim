using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTHESOUND : MonoBehaviour
{
    AudioSource m_MyAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        //Fetch the AudioSource from the GameObject
        m_MyAudioSource = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //When the Primitive collides with the walls, it will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        //Play the audio you attach to the AudioSource component
        m_MyAudioSource.Play();
    }

    //When the Primitive exits the collision, it will change Color
    private void OnTriggerExit(Collider other)
    {
        // m_MyAudioSource.Stop(); 
       //THIS IS IF YOU WANT THE BOP TO STOP 
    }
}
