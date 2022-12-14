using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public int activeWeapon;
    public List<GameObject> weapons;

    private void Start()
    {
        weapons = new List<GameObject>();
        foreach (Transform w in transform)
        {
            weapons.Add(w.gameObject);

            for (int i = 0; i < weapons.Count; i++)
            {
                weapons[i].SetActive(i == activeWeapon);
            }
        }
    }
}
