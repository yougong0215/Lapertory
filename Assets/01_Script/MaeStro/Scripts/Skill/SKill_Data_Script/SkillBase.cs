using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillBase : MonoBehaviour
{
    [SerializeField] private SkillData _thisSkillData;
    public KeyCode skillKey;

    public virtual void UseSkill()
    {

    }
}
