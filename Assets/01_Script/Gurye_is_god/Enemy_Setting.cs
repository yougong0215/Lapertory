using UnityEngine;

[CreateAssetMenu(fileName = "EnemySetting", menuName = "SO")]
[SerializeField]
public class Enemy_Setting : ScriptableObject
{
    [SerializeField] private float maxhp;
    public float MaxHp => maxhp;
    [SerializeField] private float damage;
    public float Damage => damage;
    [SerializeField] private bool isLongDistanceAttack;
    public bool IsLongDistanceAttack => isLongDistanceAttack;
    [SerializeField] private float attackRange;
    public float AttackRange => attackRange;
    [SerializeField] private float timeBetweenAttack;
    public float TimeBetweenAttacks => timeBetweenAttack;
}
