using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMoudle
{
    public string monsterPath = "/Resources/config/MonsterConfig/Monster.xlsx";
    public List<Monster> monsterList = new List<Monster>();

    public void ParseMonsterData()
    {
        List<string> monstersStringData = ReadExcel.GameReadExcel(monsterPath);
        for (int i = 0; i < monstersStringData.Count; i++)
        {
            string[] monsterStringData = monstersStringData[i].Split('|');
            Monster monster = new Monster();
            if (monsterStringData.Length != 0)
            {
                monster.m_ID = int.Parse(monsterStringData[0]);
                monster.m_name = monsterStringData[1];
                monster.m_HP = float.Parse(monsterStringData[2]);
                monster.m_Attack_Damage = float.Parse(monsterStringData[3]);
                monster.m_Attack_Speed = float.Parse(monsterStringData[4]);
                monster.m_Defence = float.Parse(monsterStringData[5]);
                monster.m_Kongfu_ID = int.Parse(monsterStringData[6]);
                monster.m_Kongfu_Lvl = int.Parse(monsterStringData[7]);
                monster.m_Internal_Strength = int.Parse(monsterStringData[8]);
                monster.m_Internal_Strength_Lvl = int.Parse(monsterStringData[9]);
            }
            if(monster != null)
            {
                monsterList.Add(monster);
            }
        }
        Debug.Log("[MonsterModule][ParseMonsterData] monsterList = " + monsterList.Count);
    }

    public void TestShowMonsterData()
    {
        Debug.Log("[MonsterModule][ParseMonsterData] Monster ID = " + monsterList[0].m_ID);
        Debug.Log("[MonsterModule][ParseMonsterData] Monster Name = " + monsterList[0].m_name);
        Debug.Log("[MonsterModule][ParseMonsterData] Monster HP = " + monsterList[0].m_HP);
        Debug.Log("[MonsterModule][ParseMonsterData] Monster Attack_Damage = " + monsterList[0].m_Attack_Damage);
        Debug.Log("[MonsterModule][ParseMonsterData] Monster Attack_Speed = " + monsterList[0].m_Attack_Speed);
        Debug.Log("[MonsterModule][ParseMonsterData] Monster Defence = " + monsterList[0].m_Defence);
        Debug.Log("[MonsterModule][ParseMonsterData] Monster Kongfu_ID = " + monsterList[0].m_Kongfu_ID);
        Debug.Log("[MonsterModule][ParseMonsterData] Monster Kongfu_Lvl = " + monsterList[0].m_Kongfu_Lvl);
        Debug.Log("[MonsterModule][ParseMonsterData] Monster Internal_Strength = " + monsterList[0].m_Internal_Strength);
        Debug.Log("[MonsterModule][ParseMonsterData] Monster Internal_Strength_Lvl = " + monsterList[0].m_Internal_Strength_Lvl);
    }
}
