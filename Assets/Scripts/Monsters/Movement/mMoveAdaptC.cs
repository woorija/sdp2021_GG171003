using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mMoveAdaptC : MonoBehaviour, IMonsterMovement
{
    public GameObject Barrier;
    public IEnumerator Move()
    {
        float speed_x = Random.Range(-3f, 3f);
        float speed_y = Random.Range(-4f, -1f);
        while (true)
        {
            transform.Translate(new Vector3(0, speed_x, -speed_y) * Time.deltaTime);
            yield return null;
        }
    }

    public IEnumerator barrier_onoff()
    {
        while (true)
        {
            Barrier.SetActive(true);
            yield return new WaitForSeconds(1f);
            Barrier.SetActive(false);
            yield return new WaitForSeconds(1f);
        }
    }

    public void MoveStart()
    {
        BarrierMove();
    }

    public void BarrierMove()
    {
        StartCoroutine(Move());
        StartCoroutine(barrier_onoff());
    }
}
