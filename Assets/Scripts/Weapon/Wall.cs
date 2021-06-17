using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Weapon"))
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
        }
        else if (other.CompareTag("BossBullet"))
        {
            ObjectPoolManager.Instance.DeleteObj((int)PoolType.BossBullet, other.gameObject);
        }
    }
}
