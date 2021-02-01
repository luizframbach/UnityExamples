﻿using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public List<Stat> StatsList;

    public int this[StatEnum s]
    {
        get { return StatsList[(int)s].Value; }
        set { StatsList[(int)s].Value = value; ; }
    }

    void Awake()
    {
        StatsList = new List<Stat>();

        for (int i = 0; i < 10; i++)
        {
            Stat temp = new Stat();
            temp.Type = (StatEnum)i;
            StatsList.Add(temp);
        }
    }
}
