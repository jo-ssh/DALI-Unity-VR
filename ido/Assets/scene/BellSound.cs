using UnityEngine;
using System.Collections;

public class BellSound : MonoBehaviour {
	
	public AudioClip bellhSoft;
	public AudioClip bellHard;
		
	private AudioSource source;
	private float lowPitchRange = .75F;
	private float highPitchRange = 1.5F;
	private float velToVol = .2F;
	private float velocityClipSplit = 10F;
		
			
void Awake () {
			source = GetComponent<AudioSource>();
		}
}
