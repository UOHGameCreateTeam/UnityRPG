using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TAMIYANOMAR_battle_manager : MonoBehaviour
{
    [SerializeField] private GameObject Enemy_1;
    [SerializeField] private GameObject Enemy_2;
    [SerializeField] private GameObject Enemy_3;

    private bool battleClear = false;

    private bool battleActive = false;
    void Update()
    {
        if(battleActive == true)
        {
            Enemy_1.SetActive(true);
            Enemy_2.SetActive(true);
            Enemy_3.SetActive(true);
        }

        //�o�g���N���A�̔���

    }

    public bool getBattleClear()
    {
        return battleClear;
    }

    public void setActive()
    {
        battleClear = true;
    }    
}
