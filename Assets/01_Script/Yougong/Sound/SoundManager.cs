using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public enum Sound
{
    Master = 0,
    SFX = 1,
    BGM = 2,
    EnemySound = 3
}

public class SoundManager : MonoBehaviour
{
    private SoundManager _instance = null;

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

    AudioSource _audio;
    private void OnEnable()
    {
        for(int i =0; i < transform.childCount; ++i)
        {

        }
    }

    public void PlayOneShot(AudioClip Audio, Sound enums = Sound.Master)
    {
        transform.GetChild((int)enums).gameObject.GetComponent<> 
    }
}
