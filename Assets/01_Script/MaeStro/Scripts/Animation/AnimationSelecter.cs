using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ActionMenu;
using System;

public class AnimationSelecter : MonoBehaviour
{
    public static AnimationSelecter animationSelecter;

    [SerializeField] AnimContainer _animContainer;
    AnimationController _animationController;
    Dictionary<AnimationMenu, string> _aniDic = null;
    private void Awake()
    {
        _aniDic = new Dictionary<AnimationMenu, string>();
        _animationController = GetComponent<AnimationController>();

        if (animationSelecter == null)
        {
            animationSelecter = this;
        }
    }

    private void Start()
    {
        foreach (AnimationMenu animation in Enum.GetValues(typeof(AnimationMenu)))
        {
            foreach (AnimationClip selectAni in _animContainer.playerAnimationList)
            {
                if (selectAni.name.Contains($"{animation}"))
                {
                    _aniDic.Add(animation, $"is{animation}");
                }
            }
        }
    }

    public void AccesAnimation(AnimationMenu anima)
    {
        _animationController.SettingAnimation(_aniDic[anima]);
    }
    
}
