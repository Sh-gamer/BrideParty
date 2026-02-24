using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource _Music;
    public AudioSource _SFX;


   // public AudioClip _MusicClip;
    public AudioClip _Point;
    public AudioClip _Enemy;


    public bool _isMusicPlaying = true;
    public bool _isSFXPlaying = true;




    //private void Start()
    //{
    //    _Music.Play();
       
    //}

    public void PlayAudio(AudioClip clip)
    {
        if (_isSFXPlaying)
        {
            Debug.Log("SOund!");
            _SFX.PlayOneShot(clip);
        }
    }
    private void Update()
    {
        if (_isMusicPlaying)
        {
            _Music.mute = false;
        }
        else
        {
            _Music.mute = true;
        }
    }
}
