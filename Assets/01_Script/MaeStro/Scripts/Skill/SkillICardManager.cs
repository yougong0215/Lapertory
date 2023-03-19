using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SkillICardManager : MonoBehaviour
{
    public List<GameObject> currentSkillCardList = new List<GameObject>();
    PlayerSkill _playerSkill;

    private void Awake()
    {
        _playerSkill = GameObject.Find("Player").GetComponent<PlayerSkill>();
    }
    public void CompleteSelectCard(GameObject selectCard)
    {
        currentSkillCardList.Remove(selectCard);

        EventSelectSkillCard(selectCard);
        EventUnSelectSkillCard(currentSkillCardList);
    }
    private void EventSelectSkillCard(GameObject selectCard)
    {
        SkillCard _selectSkillcard = selectCard.GetComponent<SkillCard>();
        Debug.Log(_selectSkillcard.skillData);
        _playerSkill.playerCanUseSkillList.Add(_selectSkillcard.skillData);
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
    }
}
