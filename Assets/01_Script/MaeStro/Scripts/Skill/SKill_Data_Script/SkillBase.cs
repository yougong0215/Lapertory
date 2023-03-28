using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillBase : MonoBehaviour
{
    public bool isFirst = true;
    //���� ������ �޴� �� �̴� ������.
    public SkillData thisSkillData;
    public SkillUpgradeValue_Data _upgradeValue;

    public int level = 1;
    public KeyCode skillKey;
    public string skillName;
    public float skillCoolTime;
    public string skillInfo;

    public float effectDieTime;
    public Vector3 producePos;
    public GameObject skillEffect;

    private void Start()
    {
        isFirst = true;
    }

    public virtual void SetSkill()
    {

    }

    public virtual void SettingSkillValue(int setLevelValue)
    {

    }
}
