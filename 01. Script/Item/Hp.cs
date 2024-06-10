using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp : MonoBehaviour
{
    public static Hp instance;
    public int maxHp = 3;
    public int curHp;
    void Start()
    {
        if (instance == null)
            instance = this;
        curHp = maxHp;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Object"))
        {
            TakeDamage();
        }
    }

    private void TakeDamage()
    {
        if (curHp > 0)
        {
            curHp -= 1;
        }
    }
}
