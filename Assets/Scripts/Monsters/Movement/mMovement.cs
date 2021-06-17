using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mMovement : MonoBehaviour,IMonsterMovement
{
    public void MoveStart()
    {
        StartCoroutine(Move());
    }

    public IEnumerator Move()
    {
        while (true)
        {
            transform.Translate(new Vector3(0, -3, 0) * Time.deltaTime);
            yield return null;
        }
    }
}
