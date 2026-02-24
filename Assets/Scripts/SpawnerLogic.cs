using UnityEngine;

public class SpawnerLogic : MonoBehaviour
{
    private float MinX = -3.15f; 
    private float MaxX = 3.15f;
    private int SpawnY = 6;
    public float SpawnerDelayDebug ;
    public GameObject[] SpawnObjects;
    public GameObject _HealthItem;


        private void Start()
    {

       
        InvokeRepeating(nameof(Spawner),1f,GameManager.instance.SpawnerDelay);
        
    }

    public void Spawner()
    {
        
        int RandomNumber = Random.Range(5, 15);
        float xPosiotion = Random.Range(MinX, MaxX);
        int RandomObjects = Random.Range(0, SpawnObjects.Length);
        Vector3 SpawnLocations = new Vector3(xPosiotion, SpawnY, 0);
        if (RandomNumber > 13)
        {
            Instantiate(_HealthItem, SpawnLocations, Quaternion.identity);
        }
        else
        {
           GameObject obj= Instantiate(SpawnObjects[RandomObjects], SpawnLocations, Quaternion.identity);
            obj.GetComponent<DummyMove>().MovingDown(GameManager.instance.DummySpeed);
        }

        
    }
    
}
