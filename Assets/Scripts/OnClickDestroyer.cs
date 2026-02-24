using UnityEngine;

public class OnClickDestroyer : MonoBehaviour
{



    
    private void OnMouseDown()
    {

        if(TryGetComponent<Enemy>(out var enemy))
        {
            enemy.ItemBehaviors();
        }
        if (TryGetComponent<HealthItemLogic>(out var healthItemlogic))
        {
            healthItemlogic.ItemBehaviors();
        }
        else if(TryGetComponent<ScoreItem>(out var scoreItem))
        {
            scoreItem.ItemBehaviors();
        }
        Destroy(this.gameObject);
        
    }
}
