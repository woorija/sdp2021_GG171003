using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    protected IMonsterMovement Move;
    protected MonsterHP HP;
    protected virtual void Start()
    {
        HP = GetComponent<MonsterHP>();
        HP.HPInit();
        Move.MoveStart();
    }

    protected virtual void OnEnable()
    {
        if(HP != null)
            HP.HPInit();
        if (Move != null)
            Move.MoveStart();

        GameManager.Instance.DieNotify += OnNotity;
    }

    protected virtual void OnDisable()
    {
        GameManager.Instance.DieNotify -= OnNotity;
    }

    protected virtual void Die()
    {
    }

    protected virtual void OnNotity()
    {

    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Weapon"))
        {
            if (HP.hp > 0)
            {
                switch (other.GetComponent<BulletType>().Get_Type())
                {
                    case (int)PoolType.Bullet:
                        ObjectPoolManager.Instance.DeleteObj((int)PoolType.Bullet, other.gameObject);
                        break;
                    case (int)PoolType.Missile:
                        ObjectPoolManager.Instance.DeleteObj((int)PoolType.Missile, other.gameObject);
                        break;
                    case (int)PoolType.Arrow:
                        ObjectPoolManager.Instance.DeleteObj((int)PoolType.Arrow, other.gameObject);
                        break;
                }
                if (HP.Hit(1))
                {
                    GameManager.Instance.kill_monster();
                    Die();
                }
            }
        }else if (other.CompareTag("MonsterWall"))
        {
            Die();
        }
    }
}
