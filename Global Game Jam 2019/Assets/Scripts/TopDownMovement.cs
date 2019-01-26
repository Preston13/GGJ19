using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed = 3f;

    private Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        player.transform.position += movement * moveSpeed * Time.deltaTime;
    }
}
