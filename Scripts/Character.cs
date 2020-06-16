using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character : MonoBehaviour
{
    public float health = 20f;
    public float stamina = 20f;
    public float moveSpeed = 5f;
    
    public void SetHealth(float newHealth){
        this.health = newHealth;
    }

    public void AddHealth(float boost){
        this.health += boost;
    }

    public void RemoveHealth(float damage){
        this.health -= damage;
    }

    public void SetStamina(float newStamina){
        this.stamina = newStamina;
    }

    public void AddStamina(float boost){
        this.stamina += boost;
    }

    public void RemoveStamina(float damage){
        this.stamina -= damage;
    }

    public void SetMoveSpeed(float newMS){
        this.moveSpeed = newMS;
    }
}