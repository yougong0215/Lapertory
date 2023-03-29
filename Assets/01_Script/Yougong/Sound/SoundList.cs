using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "SoundObj", menuName = "SoundScriptable/ObjList")]
public class SoundList : ScriptableObject
{
    [SerializeField] public List<AudioClip> audio;
}
