using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puz : MonoBehaviour {

    public float speed;
    public GameObject player;

    void Update()
    {
        Vector3 localPosition = player.transform.position - transform.position;
        localPosition = localPosition.normalized; // The normalized direction in LOCAL space
        transform.Translate(localPosition.x * Time.deltaTime * speed, localPosition.y * Time.deltaTime * speed, localPosition.z * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ZidEnemy")

            Destroy(gameObject);
    }
}
