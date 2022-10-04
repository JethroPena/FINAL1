using UnityEngine;

public class Music: MonoBehaviour
{


    private static Music MusicPlayer;


    void Awake()
    {
        DontDestroyOnLoad(this);


        if (MusicPlayer == null) 
        {
            MusicPlayer = this;
        }
        else {
            Destroy(gameObject);
        }
    }
}