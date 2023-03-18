using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AnimationMenu;
using System;

public class AnimationSelecter : MonoBehaviour
{
    public static AnimationSelecter animationSelecter;

    [SerializeField] AnimContainer _animContainer;
    AnimationController _animationController;
    Dictionary<animationMenu, string> _aniDic = null;
    private void Awake()
    {
        _aniDic = new Dictionary<animationMenu, string>();
        _animationController = GetComponent<AnimationController>();

        if (animationSelecter == null)
        {
            animationSelecter = this;
        }
    }

    private void Start()
    {
        foreach (animationMenu animation in Enum.GetValues(typeof(animationMenu)))
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

    public void AccesAnimation(animationMenu anima)
    {
        _animationController.SettingAnimation(_aniDic[anima]);
    }
    public void UnLockAnimation(animationMenu anim)
    {
        _animationController.DeAccesAnimation(_aniDic[anim]);
    }
}
