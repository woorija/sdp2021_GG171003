using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType
{
    Bullet,
    Missile,
    Arrow
}

public class WaeponManager : MonoSingleton<WaeponManager>
{
    public GameObject _arrow;
    public GameObject _bullet;
    public GameObject _missile;

    GameObject myWeapon;

    private IWeapon weapon;

    // 무기 교환 가능하게...
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
                break;

            case WeaponType.Missile:
                weapon = gameObject.AddComponent<Missile>();
                myWeapon = _missile;
                break;

            case WeaponType.Arrow:
                weapon = gameObject.AddComponent<Arrow>();
                myWeapon = _arrow;
                break;

            default:
                weapon = gameObject.AddComponent<Bullet>();
                myWeapon = _bullet;
                break;
        }
    }

    public override void Start()
    {
        base.Start();
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
        weapon.Shoot(myWeapon);
    }
}

