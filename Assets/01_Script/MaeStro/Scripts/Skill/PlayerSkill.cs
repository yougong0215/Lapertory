using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkill : MonoBehaviour
{
    public List<SkillData> playerCanUseSkillList = new List<SkillData>();
    GameObject _skillPrefab;
    SkillKeySelecter _skillKeySelecter;

    private void Awake()
    {
        _skillKeySelecter = GameObject.Find("SkillKeySelecter").GetComponent<SkillKeySelecter>();
    }
    private void Update()
    {
        if(Input.anyKeyDown)
        {
            foreach(var skillDic in _skillKeySelecter.skillKeyDic)
            {
                if(Input.GetKeyDown(skillDic.Key))
                {
                    UseSkill(skillDic.Value);
                }
            }
        }
    }

    void UseSkill(SkillData _skillData)
    {
        _skillPrefab = Instantiate(_skillData.effecctPrefab);
        _skillPrefab.transform.rotation = this.transform.rotation;
        _skillPrefab.transform.position = this.transform.position + _skillData.producePos;

        KillEffect(_skillData.effectDieTime);
    }

    void KillEffect(float time)
    {
        Destroy(_skillPrefab, time);
    }
}
