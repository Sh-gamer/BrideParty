using UnityEngine;

public class DummyMove : MonoBehaviour
{

    private int _Speed = 5;



    public void MovingDown(int speed)
    {
        _Speed = speed;
        transform.Translate(Vector2.down * _Speed*Time.deltaTime);
    }
    private void Update()
    {
        MovingDown(_Speed);
        Destroy(this.gameObject, 2.5f);
    }
}
