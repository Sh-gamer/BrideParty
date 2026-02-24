using UnityEngine;

public class HealthItemLogic : BASeItem
{

    

    public override void ItemBehaviors()
    {
        
        _GameManager.HealthIncreaser();
    }

   
}
