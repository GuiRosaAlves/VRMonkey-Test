using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : Character
{
    public AIAgent aiAgent;
    
    public override void DealDamage(float val)
    {
        aiAgent.GettingShot();
    }
}
