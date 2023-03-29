using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;


public class Enemy_Controller : MonoBehaviour, IDamage
{
    [Header("Reference")]
    [SerializeField] private Enemy_Setting _set;
    [SerializeField] private LayerMask _lay;
    [SerializeField] private GameObject ball;

    enum State
    {
        idle,
        attack,
        follow,
        Die
    }
    State _state;


    private float _CurrentHP;
    private Transform _target;
    private NavMeshAgent _agent;


    void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        _target = GameObject.Find("Player").transform;
        _state = State.idle;

        #region setting
        _CurrentHP = _set.MaxHp;

        #endregion
    }


    void Update()
    {
        if (IsAttackRange())
        {
            Attack();
            return;
        }

        if (_state == State.idle || _state == State.follow)
        {
            follow();
        }
    }

    private bool IsAttackRange()
    {
        if (Physics.CheckSphere(transform.position, _set.AttackRange, _lay))
        {
            return true;
        }
        return false;
    }

    private void follow()
    {
        _agent.SetDestination(_target.position);
        _state = State.follow;
    }

    private void Attack()
    {


        if (_set.IsLongDistanceAttack)
        {
            if (_state != State.attack)
            {
                StartCoroutine(LongDistanceAttack());
                _state = State.attack;
            }


            //rb.AddForce(transform.up * 8f, ForceMode.Impulse);

        }
        else
        {
            _agent.SetDestination(transform.position);
            transform.LookAt(_target);
        }
    }

    private IEnumerator LongDistanceAttack()
    {
        _agent.SetDestination(transform.position);
        transform.LookAt(_target);

        var rb = Instantiate(ball, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * 32f, ForceMode.Impulse);

        yield return new WaitForSeconds(_set.TimeBetweenAttacks);
        _state = State.idle;
    }

    private void Die()
    {

    }

    public void IDamage(float Damage)
    {
        _CurrentHP -= Damage;

        if (_CurrentHP <= 0)
        {
            Die();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        IDamage hitTarget = other.GetComponent<IDamage>();

        if (hitTarget != null)
        {
            hitTarget.IDamage(_set.Damage);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, _set.AttackRange);
    }
}
