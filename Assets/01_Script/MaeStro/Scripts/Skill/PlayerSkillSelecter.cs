using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerSkillSelecter : MonoBehaviour
{
    private PlayerSkill _playerSkill;
    [SerializeField] private List<GameObject> _skillCardList = new List<GameObject>();
    [SerializeField] private List<GameObject> _currentLookSkillCardList = new List<GameObject>();
    [SerializeField] private Vector3[] _skillCardPos;
    [SerializeField] private GameObject skillCanvas;
    private  SkillCardBase _skillCardData;

    [Header("스킬 정보")]
    private string _skillName;
    private float _skillCoolTime;
    private string _skillInfo;

    [Header("카드 요소")]
    TextMeshProUGUI nameText;
    TextMeshProUGUI coolTime;
    TextMeshProUGUI info;
    private void Awake()
    {
        _playerSkill = GameObject.Find("Player").GetComponent<PlayerSkill>();
    }
    private void Start()
    {
        SkillSelectEvent(); // 임시
    }
    public void SkillSelectEvent()
    {
        for(int i = 0; i < 3; i++)
        {
            SkillInfoDetection();
            SkillInfoSetting(i);
        }
    }
    private void SkillInfoSetting(int num)
    {
        GameObject skillCard = Instantiate(_skillCardList[num], skillCanvas.transform);
        _currentLookSkillCardList.Add(skillCard);

        skillCard.name = $"SkillCard_{num + 1}";
        skillCard.transform.localPosition = _skillCardPos[num]; 

        #region  텍스트 받기
        nameText = skillCard.transform.Find("SkillName").GetComponent<TextMeshProUGUI>();
        coolTime = skillCard.transform.Find("SkillCoolTime").GetComponent<TextMeshProUGUI>();
        info = skillCard.transform.Find("SkillInfo").GetComponent<TextMeshProUGUI>();
        #endregion
        nameText.text = _skillCardData.skillData.skillName;
        coolTime.text = _skillCardData.skillData.skillCoolTime.ToString();
        info.text = _skillCardData.skillData.skillInfo;

        _skillCardData.toMovePos = new Vector2(_skillCardPos[num].x, 0);
        _skillCardData.CompleteSetting();
    }

    private void SkillInfoDetection()
    {
        int random = random = Random.Range(0, _skillCardList.Count);
        _skillCardData = _skillCardList[random].GetComponent<SkillCardBase>();
    }
}
