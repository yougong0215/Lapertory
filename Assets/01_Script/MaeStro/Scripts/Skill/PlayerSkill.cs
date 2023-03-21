using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkill : MonoBehaviour
{
    [SerializeField] private SkillData skillData;
    public List<SkillData> playerCanUseSkillList = new List<SkillData>();
    GameObject _skillPrefab;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            skillData = playerCanUseSkillList[0];
            _skillPrefab = Instantiate(skillData.effecctPrefab);
            _skillPrefab.transform.rotation = this.transform.rotation;
            _skillPrefab.transform.position = this.transform.position + skillData.producePos;

            KillEffect(skillData.effectDieTime);
        }
    }

    void KillEffect(float time)
    {
        Destroy(_skillPrefab, time);
    }
}
