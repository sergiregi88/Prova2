using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
[CreateAssetMenu(fileName ="Audios", menuName ="AudioManager")]
public class AudioManagerMap : ScriptableObject
{
    [System.Serializable]
    public class Audios
    {
        public AudioMixers audioMixer;
        public ScriptObjAudioSource audioSource;
    }
    [System.Serializable]
    public class AudiosScene
    {
        public string SceneName;
        public AudioSceneMixers audioMixer;
        public ScriptObjAudioSource audioSource;
    }

    public Audios[] AudiosDictionary;
    public AudiosScene[] AudiosSceneDicctionary;
}