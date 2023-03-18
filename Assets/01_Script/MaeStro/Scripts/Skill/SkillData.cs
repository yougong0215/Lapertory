using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkillData", menuName = "Create_SkillData", order = 0)]
public class SkillData : ScriptableObject
{
    [SerializeField] private string _skillName;
    public string skillName { get { return _skillName; } }

    [SerializeField] private float _skillCoolTime;
    public float skillCoolTime { get { return _skillCoolTime; } }

    [SerializeField] private string _skillInfo;
    public string skillInfo { get { return _skillInfo; } }
}
