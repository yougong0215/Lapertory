using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleSkill : SkillBase
{
    bool isFirst = true;
    public override void SetSkill()
    {
        if(isFirst)
        {
            FirstSetting();
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
        effectDieTime = thisSkillData.effectDieTime;
        producePos = thisSkillData.producePos;
        skillEffect = thisSkillData.effecctPrefab;
    }


    public override void SettingSkillValue(int setLevelValue)
    {

    }
}
