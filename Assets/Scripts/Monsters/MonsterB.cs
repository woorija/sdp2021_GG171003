using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterB : Monster
{
    protected override void Start()
    {
        Move = GetComponent<mMoveAdaptB>();
        base.Start();
    }
    protected override void OnDisable()
    {
        base.OnDisable();
    }

    protected override void OnEnable()
    {
        base.OnEnable();
    }

    protected override void Die()
    {
        ObjectPoolManager.Instance.DeleteObj((int)PoolType.MonsterB, gameObject);
    }

    protected override void OnNotity()
    {
        Die();
    }
    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
    }
}
