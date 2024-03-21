using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeIn : MonoBehaviour
{
	AudioSource myAudioSource;
	public float currentVolume = .27f;

	private void OnEnable()
	{
		VolumeOutScript.onVolumeChange += ReceiveVolumeLevel;
	}
	private void OnDisable()
	{
		VolumeOutScript.onVolumeChange -= ReceiveVolumeLevel;
	}
	private void Start()
	{
		myAudioSource = GetComponent<AudioSource>();
	}
	void ReceiveVolumeLevel(float vol)
	{
		myAudioSource.volume = vol;
		currentVolume = vol;
	}
}
