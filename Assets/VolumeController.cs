using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeController : MonoBehaviour
{
    public MusicSound m;
    public PlayerSound p;
    public AudioSource player, music;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player.volume = p.volume;
        music.volume = m.volume;
    }
}
