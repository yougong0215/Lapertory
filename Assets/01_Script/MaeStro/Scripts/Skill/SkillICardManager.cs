using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SkillICardManager : MonoBehaviour
{
    public List<GameObject> currentSkillCardList = new List<GameObject>();
    PlayerSkill _playerSkill;
    SkillKeySelecter _skillKeySelecter;
    SkillCard _skillCard;
    GameObject _skillObject;
    private void Awake()
    {
        _playerSkill = GameObject.Find("Player").GetComponent<PlayerSkill>();
        _skillKeySelecter = GameObject.Find("SkillKeySelecter").GetComponent<SkillKeySelecter>();
    }
    public void CompleteSelectCard(GameObject selectCard)
    {
        _skillCard = selectCard.GetComponent<SkillCard>();
        currentSkillCardList.Remove(selectCard);

        if(_playerSkill.playerCanUseSkillList.Count != 0)
        {
            foreach (GameObject _selectSkill in _playerSkill.playerSkillList)
            {
                SkillBase _skillBase = _selectSkill.GetComponent<SkillBase>();

                if (_skillBase.thisSkillData == _skillCard.skillData)
                {
                    _skillObject = _selectSkill;
                }
                
                    
            }
        }
        
        _skillKeySelecter.SettingKey(_skillCard.skillData.skillKey, _skillObject);

        EventSelectSkillCard(selectCard);
        EventUnSelectSkillCard(currentSkillCardList);
    }
    private void EventSelectSkillCard(GameObject selectCard)
    {
        Debug.Log(_skillObject);
        SkillBase skillBase = _skillObject.GetComponent<SkillBase>();
        
        skillBase.SetSkill();
        _playerSkill.playerCanUseSkillList.Add(_skillObject);
        StartCoroutine(SelectCardEventCoroutine(selectCard));
    }
    IEnumerator SelectCardEventCoroutine(GameObject selectCard)
    {
        //dd
        selectCard.transform.DOScale(new Vector3(1.2f, 1.2f), 0.5f);
        yield return new WaitForSeconds(0.5f);
        selectCard.transform.DOLocalMoveY(-900, 0.7f).SetEase(Ease.InBack);
        Destroy(selectCard, 0.7f);
    }
    private void EventUnSelectSkillCard(List<GameObject> unSelectCardList)
    {
        foreach(GameObject unSelectCard in unSelectCardList)
        {
            unSelectCard.transform.DOLocalMoveY(-900, 0.6f).SetEase(Ease.InBack);
            Destroy(unSelectCard, 0.7f);
        }
        currentSkillCardList.Clear();
    }
}
