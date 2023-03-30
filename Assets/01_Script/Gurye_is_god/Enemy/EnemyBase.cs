using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public struct Data
{
    public float Damage;
    public float Speed;
    public float AttackRange;
    public float TimeBetweenAttack;
    public float MaxHp;
}

public abstract class EnemyBase : MonoBehaviour, IDamage
{

    protected Data _data = new Data();
    private NavMeshAgent _agent;
    [SerializeField] private LayerMask _lay;


    private float _CurrentHP { get { return _CurrentHP; } set { if (_CurrentHP <= 0) OnDie(); _CurrentHP = value; } }
    private float _lasttime;

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        Test();
    }

    protected abstract void Test();
    private void FixedUpdate()
    {
        Think();
    }

    private void Think()
    {
        if (IsAttackRange() && Time.time > _lasttime + _data.TimeBetweenAttack)
        {
            _lasttime = Time.time;
            Attack();
        }
        else
        {
            Move();
        }
    }

    protected abstract void Move();

    private bool IsAttackRange()
    {
        if (Physics.CheckSphere(transform.position, _data.AttackRange, _lay))
        {
            return true;
        }
        return false;
    }

    protected abstract void Attack();
    protected abstract void Initsetting();

    public void IDamage(float Damage, Vector3 point)
    {
        throw new NotImplementedException();
    }

    private void OnDie()
    {
        Destroy(gameObject);
    }
}
