using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterC : Monster
{
    protected override void Start()
    {
        Move = GetComponent<mMoveAdaptC>();
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
        ObjectPoolManager.Instance.DeleteObj((int)PoolType.MonsterC, gameObject);
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
