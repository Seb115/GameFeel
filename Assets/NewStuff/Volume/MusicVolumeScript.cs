using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicVolumeScript : MonoBehaviour
{
    public MusicSound msound;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        msound.volume = (rb.transform.position.x - 48) / 3;
    }
}
