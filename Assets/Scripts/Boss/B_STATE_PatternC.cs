using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_STATE_PatternC : State
{
    GameObject player;
    Vector3 dir;
    float _angle;
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
        _angle = -6;
        yield return null;
        for (int i = 0; i < 12; i++)
        {
            Fire();
            _angle += 90;
            yield return new WaitForSeconds(0.5f);
        }



        if (Random.Range(0, 2) == 0)
        {
            gameObject.GetComponent<Boss>().Set_State(BossState.STATE_PatternA);
        }
        else
        {
            gameObject.GetComponent<Boss>().Set_State(BossState.STATE_PatternB);
        }
    }

    void Fire()
    {
        for (int i = 0; i < 20; i++)
        {
            GameObject bullet = ObjectPoolManager.Instance.MakeObj((int)PoolType.BossBullet);
            bullet.GetComponent<Rigidbody>().velocity = Vector3.zero;
            bullet.transform.position = transform.position;

            dir = new Vector3(Mathf.Cos(Mathf.PI * 2 * (90 + _angle) / 360), Mathf.Sin(Mathf.PI * 2 * (90 + _angle) / 360), 0);
            bullet.GetComponent<Rigidbody>().AddForce(dir.normalized * 3, ForceMode.Impulse);
            _angle += 92;
        }
    }
}
