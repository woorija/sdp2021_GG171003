using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMonsterMovement
{
    public void MoveStart();
    IEnumerator Move();
}
