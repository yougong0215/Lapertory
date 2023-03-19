using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class PlayerSkillSelecter : MonoBehaviour
{
    [SerializeField] private List<SkillData> _skillCardDataList = new List<SkillData>();
    [SerializeField] private Vector3[] _skillCardPos;
    private  SkillCard _skillCardData;
    private SkillData _skillData;
    [SerializeField] private GameObject _skillCardMaster;

    [Header("스킬 정보")]
    private string _skillName;
    private float _skillCoolTime;
    private string _skillInfo;

    [Header("카드 요소")]
    [SerializeField] private GameObject _skillCardPrefab;
    GameObject _skillCard;
    TextMeshProUGUI nameText;
    TextMeshProUGUI coolTime;
    TextMeshProUGUI info;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            SkillSelectEvent(); // 임시
        }
    }
    public void SkillSelectEvent()
    {
        StartCoroutine(EventStart());
    }
    IEnumerator EventStart()
    {
        for (int i = 0; i < 3; i++)
        {
            SkillInfoDetection();
            SkillInfoSetting(i);
            _skillCard.transform.DOLocalMoveY(0, 1f).SetEase(Ease.OutBack);

            yield return new WaitForSeconds(0.15f);
        }
        // 빰빠밤 이벤트
    }
    private void SkillInfoSetting(int num)
    {
        _skillCard = Instantiate(_skillCardPrefab, _skillCardMaster.transform);

        _skillCard.name = $"SkillCard_{num + 1}";
        _skillCard.transform.localPosition = _skillCardPos[num];
        _skillCardData = _skillCard.GetComponent<SkillCard>();

        SettingCard();
    }
    private void SettingCard()
    {
        _skillCardData.skillData = _skillData;
        _skillCardData.SetDataValue();
        #region  텍스트 받기
        nameText = _skillCard.transform.Find("SkillName").GetComponent<TextMeshProUGUI>();
        coolTime = _skillCard.transform.Find("SkillCoolTime").GetComponent<TextMeshProUGUI>();
        info = _skillCard.transform.Find("SkillInfo").GetComponent<TextMeshProUGUI>();
        #endregion
        nameText.text = _skillCardData.skillData.skillName;
        coolTime.text = _skillCardData.skillData.skillCoolTime.ToString();
        info.text = _skillCardData.skillData.skillInfo;
    }
    private void SkillInfoDetection()
    {
        int random = Random.Range(0, _skillCardDataList.Count);
        _skillData = _skillCardDataList[random];
    }
}
