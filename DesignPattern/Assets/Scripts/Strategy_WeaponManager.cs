using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MyWeapon Ŭ������ ���� Shoot�޼��� ����� ���� �ʰ�, ������ ���ӿ�����Ʈ�� Bullet���� �߻��ϴ� �������� ��ȯ��
// ���� Bullet Ÿ���� �к��ϱ� ���� enum�� �����

public enum WeaponType
{
    Laser,
    Missile,
    Arrow
}
public class Strategy_WeaponManager : MonoBehaviour
{
    public GameObject _arrow;
    public GameObject _laser;
    public GameObject _missile;

    private GameObject myWeapon;

    private IWeapon weapon;

    private void setWeaponType (WeaponType weaponType)
    {
        Component c = gameObject.GetComponent<IWeapon>() as Component;

        if(c != null)
        {
            Destroy(c);
        }

        switch (weaponType)
        {
            case WeaponType.Arrow:
                weapon = gameObject.AddComponent<Arrow>();
                myWeapon = _arrow;
                break;
            case WeaponType.Laser:
                weapon = gameObject.AddComponent<Laser>();
                myWeapon = _laser;
                break;
            case WeaponType.Missile:
                weapon = gameObject.AddComponent<Missile>();
                myWeapon = _missile;
                break;
            default:
                weapon = gameObject.AddComponent<Arrow>();
                myWeapon = _arrow;
                break;

        }

    }

    private void Start()
    {
        //myweapon = new MyWeapon();

        //Set default bullet
        //myweapon.setWeapon(new Arrow());

        //Set default bullet
        setWeaponType(WeaponType.Arrow);
    }

    public void ChangeMissile()
    {
        setWeaponType(WeaponType.Missile);
    }

    public void ChangeLaser()
    {
        setWeaponType(WeaponType.Laser);

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
