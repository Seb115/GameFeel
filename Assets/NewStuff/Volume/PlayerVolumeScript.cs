using Platformer.Mechanics;
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
        rb.transform.position = new Vector3(Mathf.Clamp(rb.transform.position.x, 48.5f, 50.5f), rb.transform.position.y, rb.transform.position.z);
        psound.volume = (rb.transform.position.x - 48.5f) / 2;
    }

    public void OnCollisionStay2D(Collision2D col)
    {
        Debug.Log("biem");
        Vector2 dir = transform.position - col.transform.position;
        if (dir.y < 0)
            return;
        dir.y = 0;
        dir.Normalize();
        GetComponent<Rigidbody2D>().velocity = dir;
    }
}
