using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EngraveData", menuName = "Create_EngraveData", order = 0)]
public class EngraveData : ScriptableObject
{
    [SerializeField] private string _engraveName;
    public string engraveName { get { return _engraveName; } }

    [SerializeField] private GameObject _engraveDataObject;
    public GameObject engrave { get { return _engraveDataObject; } }
}
