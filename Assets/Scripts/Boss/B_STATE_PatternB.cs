using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_STATE_PatternB : State
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

        float angle = 5f;

        for(int i = 0; i < 100; i++)
        {
            GameObject bullet = ObjectPoolManager.Instance.MakeObj((int)PoolType.BossBullet);
            bullet.GetComponent<Rigidbody>().velocity = Vector3.zero;
            bullet.transform.position = transform.position;

            dir = new Vector3(Mathf.Cos(Mathf.PI * 2 * (90 + angle) / 360), Mathf.Sin(Mathf.PI * 2 * (90 + angle) / 360), 0);
            bullet.GetComponent<Rigidbody>().AddForce(dir.normalized * 3, ForceMode.Impulse);
            angle += 101;
            yield return new WaitForSeconds(0.05f);
        }




        if (Random.Range(0, 2) == 0)
        {
            gameObject.GetComponent<Boss>().Set_State(BossState.STATE_PatternA);
        }
        else
        {
            gameObject.GetComponent<Boss>().Set_State(BossState.STATE_PatternC);
        }
    }
}
