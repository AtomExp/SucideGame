using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeOutScript : MonoBehaviour
{
	public delegate void VolumeChanged(float vol);
	public static VolumeChanged onVolumeChange;

    public void ReceiveVolumeLevel(float vol)
	{
		onVolumeChange(vol);
	}
}
