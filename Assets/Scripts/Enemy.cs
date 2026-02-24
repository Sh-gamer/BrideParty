using UnityEngine;
//using GameManagerOOP;
public class Enemy : BASeItem
{

    public override void ItemBehaviors()
    {
        _SoundManager.PlayAudio(_SoundManager._Enemy);
        _GameManager.DeathLogic();
    }
    //public override void PlaySound()
    //{

    //    _SoundManager.PlayAudio(_SoundManager._Enemy);
    //}
}
