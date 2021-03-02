using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : Character
{
    public AIAgent aiAgent;

    private void Awake()
    {
        aiAgent = gameObject.GetComponent<AIAgent>();
    }
    
    public override void DealDamage(float val)
    {
        aiAgent.GettingShot();
        dead = true;
    }
}
