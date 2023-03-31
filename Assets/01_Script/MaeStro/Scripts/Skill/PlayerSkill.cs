using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkill : MonoBehaviour
{
    public List<GameObject> playerCanUseSkillList = new List<GameObject>();
    public List<GameObject> playerSkillList = new List<GameObject>();
    GameObject _skillPrefab;
    SkillKeySelecter _skillKeySelecter;
    [SerializeField] private Transform targetPos;

    public bool canUseSkill;
    private void Awake()
    {
        _skillKeySelecter = GameObject.Find("SkillKeySelecter").GetComponent<SkillKeySelecter>();

        foreach(GameObject skillObj in playerSkillList)
        {
            SkillBase _skillBase = skillObj.GetComponent<SkillBase>();
            _skillBase.isFirst = true;
            _skillBase.engraveList.Clear();
        }
    }
    private void Update()
    {
        if(Input.anyKeyDown && canUseSkill)
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

    void UseSkill(GameObject _skillObject)
    {
        SkillBase _skillBase = _skillObject.GetComponent<SkillBase>();

        _skillPrefab = Instantiate(_skillBase.skillEffect);
        _skillPrefab.transform.position = transform.position + transform.forward * 10;
        KillEffect(_skillBase.effectDieTime);
    }

    void KillEffect(float time)
    {
        Destroy(_skillPrefab, time);
    }
}
