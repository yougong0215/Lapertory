using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleSkill : SkillBase
{
    public override void SetSkill()
    {
        if(isFirst)
        {
            FirstSetting();
            isFirst = false;
        }
        else
        {
            level++;
        }
    }
    private void FirstSetting()
    {
        skillKey = thisSkillData.skillKey;
        skillName = thisSkillData.skillName;
        skillCoolTime = thisSkillData.skillCoolTime;
        skillInfo = thisSkillData.skillInfo;
        skillEffect = thisSkillData.effecctPrefab;
    }


    public override void SettingSkillValue(int setLevelValue)
    {

    }
}
