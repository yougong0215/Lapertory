using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillCard : MonoBehaviour
{
    [Header("기본 정보")]
    public SkillData skillData;

    public string skillName;
    public float skillCool;
    public string skillInfo;

    Image _thisCardImage;
    SkillICardManager _skillICardManager;
    private void Awake()
    {
        _thisCardImage = GetComponent<Image>();
        _skillICardManager = GameObject.Find("SkillCard_Master").GetComponent<SkillICardManager>();
    }
    public void SetDataValue()
    {
        skillName = skillData.skillName;
        skillCool = skillData.skillCoolTime;
        skillInfo = skillData.skillInfo;
        //_thisCardImage.color = skillData.cardColor;

        _skillICardManager.currentSkillCardList.Add(this.gameObject);
    }
    public void SelectThisSkill()
    {
        _skillICardManager.CompleteSelectCard(this.gameObject);
    }
}
