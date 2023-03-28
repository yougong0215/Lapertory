using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "SkillData", menuName = "Create_SkillData", order = 0)]
public class SkillData : ScriptableObject
{
    [SerializeField] private string _skillName;
    public string skillName { get { return _skillName; } }

    [SerializeField] private float _skillCoolTime;
    public float skillCoolTime { get { return _skillCoolTime; } }

    [SerializeField] private string _skillInfo;
    public string skillInfo { get { return _skillInfo; } }

    [SerializeField] private Sprite _skillSprite;
    public Sprite skillSprite { get { return _skillSprite; } }

    [SerializeField] private GameObject _effectPrefab;
    public GameObject effecctPrefab { get { return _effectPrefab; } }

    [SerializeField] private KeyCode _skillKey;
    public KeyCode skillKey { get { return _skillKey; } }

    [SerializeField] private int _skillLevel;
    public int skillLevel { get { return _skillLevel; } }

    [SerializeField] private GameObject _skillobject;
    public GameObject skillObject { get { return _skillobject; } }
}
