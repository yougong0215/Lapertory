using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngraveSetter : MonoBehaviour
{
    [SerializeField] private List<EngraveData> _dataList = new List<EngraveData>();
    public GameObject engraveGameobject;
    public string EngraveSetting()
    {
        int rand = Random.Range(0, _dataList.Count);

        return _dataList[rand].engraveName;
    }
}
