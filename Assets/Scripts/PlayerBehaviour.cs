using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    
    public UnitHealth playerHealth = new UnitHealth(100, 100);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerTakeDmg(30);
            Debug.Log(playerHealth.Health);
        }
        
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            PlayerHeal(30); 
            Debug.Log(playerHealth.Health);
        }

    }

    private void PlayerTakeDmg(int Dmg)
    {
        playerHealth.DmgUnit(Dmg);
    }

    private void PlayerHeal(int Heal)
    {
        playerHealth.HealUnit(Heal);
    }
}
