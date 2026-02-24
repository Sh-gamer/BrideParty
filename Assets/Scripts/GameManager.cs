using TMPro;
using UnityEngine;
using UnityEngine.UI;
//namespace GameManagerOOP
//{
public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    public SoundManager _SoundManager;
    //Properties
    public int DummySpeed { get; private set; } = 5;
    public float SpawnerDelay { get; private set; } = 0.3f;



    public int Health;
    public int MaxHealth = 3;
    private int _scorNumber ;  


    //UI Varubale
    public Image HealthBar;
    public TMP_Text _ScoreText;




    private void Awake()
    {
        instance = this;
    }
   
    private void Start()
    {
        Health = MaxHealth;
        HealthBar.fillAmount = 1;
        _SoundManager = GameObject.FindWithTag("Sound").GetComponent<SoundManager>();
    }


    public void DeathLogic()
    {
        
        if (Health > 0)
        {
            Health--;

        }
        if (Health == 0)
        {
            Time.timeScale = 0;
            Debug.Log("you Are DEAD");
        }
        Debug.Log(Health);
    }


    public void Score()
    {
        _scorNumber++;
        _ScoreText.text = "Score : " + _scorNumber;

        if (DummySpeed <= 5)
        {
        if (_scorNumber % 2 == 0)
        {
            Debug.Log("Speeded Up!");
            int Speed =+ 3;
            DummySpeed = DummySpeed + Speed;
            }

        }
        if (SpawnerDelay > 0)
        {

        if (_scorNumber % 2 == 0)
        {
            float GameBooster = +0.05f;
            SpawnerDelay =  SpawnerDelay - GameBooster;
                
        }

        }
    }
    private void Update()
    {
        if (Health == 3)
        {
            HealthBar.fillAmount = 1;
            
        }
        if (Health == 2)
        {
            HealthBar.fillAmount = 0.7f;
        }
        if (Health == 1)
        {
            HealthBar.fillAmount = 0.4f;
        }
        else if (Health == 0)
        {
            
            HealthBar.fillAmount = 0.2f;
        }




    }
    public void HealthIncreaser()
    {
        if (Health > 0 && Health < 3)
        {
            Health++;
            Debug.Log(Health);
        }
    }




    public void SFXsetting()
    {
        _SoundManager._isSFXPlaying =!_SoundManager._isSFXPlaying;
    }
    public void MusicSetting()
    {
        _SoundManager._isMusicPlaying =!_SoundManager._isMusicPlaying;
    }
}

//}