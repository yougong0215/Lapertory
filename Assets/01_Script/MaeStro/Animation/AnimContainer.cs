using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "AnimContainer", menuName = "Create_SO", order = 0)]
public class AnimContainer : ScriptableObject
{
    public List<AnimationClip> playerAnimationList = new List<AnimationClip>();
}
