using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public List<AudioClip> voiceClips = new List<AudioClip>();
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    /// <summary>
    /// Plays the specified audio clip using the AudioManager GameObject
    /// </summary>
    /// <param name="clip index">The index of the audio clip you wish to play. Must add audio clip to the voice clips list inside the AudioManager GameObject first.</param>
    public void PlayClip(int clipIndex)
    {
        audioSource.clip = voiceClips[clipIndex];
        audioSource.Play();
    }
}