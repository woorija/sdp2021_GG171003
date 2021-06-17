using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mMoveAdaptB : MonoBehaviour, IMonsterMovement
{
    public IEnumerator Move()
    {
        while (true)
        {
            transform.Translate(new Vector3(0, -2.5f, 0) * Time.deltaTime);
            yield return null;
        }
    }

    IEnumerator Teleport()
    {
        while (true)
        {
            transform.position = new Vector3(Random.Range(-6f, 6f), transform.position.y, transform.position.z);
            yield return new WaitForSeconds(1.0f);
        }
    }

    public void MoveStart()
    {
        TeleportMove();
    }

    public void TeleportMove()
    {
        StartCoroutine(Move());
        StartCoroutine(Teleport());
    }
}
