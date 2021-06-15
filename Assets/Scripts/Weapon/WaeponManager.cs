using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType
{
    Bullet,
    Missile,
    Arrow
}

public class WaeponManager : MonoBehaviour
{
    public GameObject _arrow;
    public GameObject _bullet;
    public GameObject _missile;

    GameObject myWeapon;

    private IWeapon weapon;

    float delay;
    float cur_delay;

    // ���� ��ȯ �����ϰ�...
    private void setWeaponType(WeaponType weaponType)
    {

        Component c = gameObject.GetComponent<IWeapon>() as Component;

        if (c != null)
        {
            Destroy(c);
        }

        switch (weaponType)
        {
            case WeaponType.Bullet:
                weapon = gameObject.AddComponent<Bullet>();
                myWeapon = _bullet;
                delay = 0.1f;
                break;

            case WeaponType.Missile:
                weapon = gameObject.AddComponent<Missile>();
                myWeapon = _missile;
                delay = 0.5f;
                break;

            case WeaponType.Arrow:
                weapon = gameObject.AddComponent<Arrow>();
                myWeapon = _arrow;
                delay = 0.3f;
                break;

            default:
                weapon = gameObject.AddComponent<Bullet>();
                myWeapon = _bullet;
                delay = 0.1f;
                break;
        }
        cur_delay = delay;
    }

    private void Update()
    {
        cur_delay -= Time.deltaTime;
    }

    public void Start()
    {
        setWeaponType(WeaponType.Bullet);
    }

    public void ChangeBullet()
    {
        setWeaponType(WeaponType.Bullet);
    }

    public void ChangeMissile()
    {
        setWeaponType(WeaponType.Missile);
    }

    public void ChangeArrow()
    {
        setWeaponType(WeaponType.Arrow);
    }

    public void Fire()
    {
        if (cur_delay < 0)
        {
            weapon.Shoot(myWeapon);
            cur_delay = delay;
        }
    }
}

