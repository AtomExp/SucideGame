using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRandomizer : MonoBehaviour
{
    [SerializeField] AudioClip[] sounds;

    AudioSource myAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        RandomSounds();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RandomSounds()
    {
        AudioClip clip = sounds[UnityEngine.Random.Range(0, sounds.Length)];
        myAudioSource.PlayOneShot(clip);
    }
}
