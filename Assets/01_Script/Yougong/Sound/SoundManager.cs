using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Audio;

public enum Sound
{
    SFX = 0,
    BGM = 1,
    EnemySound = 2,
    None
}

public class SoundManager : MonoBehaviour
{
    private SoundManager _instance = null;

    int _soundChannelNumber = 3;

    public SoundManager Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = this;
            }
            return _instance;
        }
    }


    AudioMixer _audioMixer;
    private void Init()
    {
        ////어드레서블로 오디오믹서 가져오기
        //_audioMixer = AddressablesManager.Instance.GetResource<AudioMixer>("MainMixer");

        ////그룹 쪼개기 순서 중요
        //var groups = _audioMixer.FindMatchingGroups(string.Empty);
        //_bgmAudioGroup = groups[1];
        //_effAudioGroup = groups[2];
        //_environmentAudioGroup = groups[3];
    }

    AudioSource _audio;

    private void Awake()
    {
        for(int i =0; i < _soundChannelNumber; i++)
        {
            GameObject obj = Instantiate(new GameObject(), transform);
            obj.AddComponent<AudioSource>().playOnAwake = false;
            obj.GetComponent<AudioSource>().outputAudioMixerGroup;

        }

    }

    public void PlayOneShot(AudioClip Audio, Sound enums = Sound.None)
    {
        transform.GetChild((int)enums).GetComponent<AudioSource>().PlayOneShot(Audio);
    }
}
