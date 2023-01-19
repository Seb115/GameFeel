using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVolumeScript : MonoBehaviour
{
    public PlayerSound psound;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        psound.volume = (rb.transform.position.x - 48) / 3;
    }
}
