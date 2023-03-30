using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EngraveData", menuName = "Create_EngraveData", order = 1)]
public class EngraveData : ScriptableObject
{
    [SerializeField] private string _engraveName;
    public string engraveName { get { return _engraveName; } }

    [SerializeField] private GameObject _engraveObject;
    public GameObject engraveObject { get { return _engraveObject; } }
}
