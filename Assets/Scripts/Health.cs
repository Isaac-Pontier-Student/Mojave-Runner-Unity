using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int healthAmount = 3;

    public void TakeDamage(int damageAmount) //this will be called when there's damage to our health, and it will remove the given amount of damage
    {
        healthAmount -= damageAmount;
        if (healthAmount <= 0)
        {
            GameManager.instance.Restart();
        }
    }

    public static void TryDamageTarget(GameObject target, int damageAmount)
    {
        Health targetHealth = target.GetComponent<Health>(); //this makes it so that other objects trying to damage the Health don't have to do .GetComponent themselves every time?

        if (targetHealth)
        {
            targetHealth.TakeDamage(damageAmount);
        }
    }
}
