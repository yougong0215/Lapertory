using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AnimationMenu;
using System;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] AnimContainer _animContainer;
    AnimationController _animationController;
    Animator _playerAnimator;
    Dictionary<animationMenu, string> _aniDic = null;
    private void Awake()
    {
        _aniDic = new Dictionary<animationMenu, string>();
        _playerAnimator = GetComponent<Animator>();
        _animationController = GetComponent<AnimationController>();
    }

    private void Start()
    {
        foreach (animationMenu animation in Enum.GetValues(typeof(animationMenu)))
        {
            foreach (AnimationClip selectAni in _animContainer.playerAnimationList)
            {
                if (selectAni.name.Contains($"{animation}"))
                {
                    Debug.Log(animation);
                    _aniDic.Add(animation, $"is{animation}");
                }
            }
        }
    }

    public void AccesAnimation(animationMenu anima)
    {
        _animationController.SettingAnimation(_aniDic[anima]);
    }
}
