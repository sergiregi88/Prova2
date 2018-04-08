using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
//[CreateAssetMenu(fileName ="AudoScource",menuName ="Audio")]
public class ScriptObjAudioSource  {

    public string nameAudio;

	public AudioClip clip;

	[Range(0f, 1f)]
	public float volume;
	[Range(0f, 1f)]
	public float volumeVariance;

	[Range(-2f, 2f)]
	public float pitch;
	[Range(0f, 1f)]
	public float pitchVariance;

	public bool loop = false;
    [HideInInspector]
    public AudioSource audioSource;
    public AudioMixerGroup audioMixerGroup;
    public bool mute;
    public bool playOnAwake;
    [Range(0,256)]
    public float priority;
    [Range(-1,1)]
    public float stereoPan;
    [Range(0, 1)]
    public float spartialBlend;
    [Range(0,1.1f)]
    public float reverbZoneMix;
    [Range(0, 5)]
    public float dopplerLevel;
    [Range(0, 360)]
    public float spread;
    public AudioRolloffMode audioRolloffMode;
    public float minDistance;
    public float maxDistance;
    public GameObject gameObject;



}
