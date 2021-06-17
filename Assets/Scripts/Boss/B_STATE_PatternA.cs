using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_STATE_PatternA : State
{
    GameObject player;
    Vector3 dir;
    public override void DoAction()
    {
        StartCoroutine(Action());
    }

    private void Start()
    {
        player = FindObjectOfType<Player>().gameObject;
    }

    IEnumerator Action()
    {
        yield return null;
        for(int i = 0; i < 12; i++)
        {
            Fire();
            yield return new WaitForSeconds(0.25f);
        }



        if (Random.Range(0, 2) == 0)
        {
            gameObject.GetComponent<Boss>().Set_State(BossState.STATE_PatternB);
        }
        else
        {
            gameObject.GetComponent<Boss>().Set_State(BossState.STATE_PatternC);
        }
    }

    void Fire()
    {
        dir = player.transform.position - transform.position;
        GameObject bullet = ObjectPoolManager.Instance.MakeObj((int)PoolType.BossBullet);
        bullet.GetComponent<Rigidbody>().velocity = Vector3.zero;
        bullet.transform.position = transform.position;
        bullet.GetComponent<Rigidbody>().AddForce(dir.normalized * 3, ForceMode.Impulse);
    }
}
