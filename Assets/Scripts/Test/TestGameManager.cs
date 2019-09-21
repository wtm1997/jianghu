using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MonsterMoudle monsterMoudle = new MonsterMoudle();
        monsterMoudle.ParseMonsterData();
        monsterMoudle.TestShowMonsterData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
