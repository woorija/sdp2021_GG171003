using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterHP : MonoBehaviour
{
    [SerializeField] int maxhp;
    public int hp { get; private set; }

    private void Start()
    {
        hp = maxhp;
    }

    public void Hit(int _damage)
    {
        hp -= _damage;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Weapon"))
        {
            if (hp > 0)
            {
                Hit(1);
                Destroy(other.gameObject);
            }
        }
    }
}
