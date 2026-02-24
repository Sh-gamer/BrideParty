using UnityEngine;

public abstract class BASeItem : MonoBehaviour
{
    public GameManager _GameManager;
    public SoundManager _SoundManager;


    private void Start()
    {
        _GameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
        _SoundManager = GameObject.FindWithTag("Sound").GetComponent<SoundManager>();

    }
    public virtual void ItemBehaviors()
    {
        _SoundManager.PlayAudio(_SoundManager._Point);
        _GameManager.Score();
    }
    //public virtual void PlaySound()
    //{

    //    _SoundManager.PlayAudio(_SoundManager._Point);
    //}
}
