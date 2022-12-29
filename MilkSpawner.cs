using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilkSpawner : MonoBehaviour
{
    public GameObject milkPrefab;
    public float spawnInterval = 1.0f;

    private float timeSinceLastSpawn = 0;
    private float spawnXPosition;
    private float spawnYPosition;
    private float despawnYPosition;

    private void Start()
    {
        spawnXPosition = transform.position.x;
        spawnYPosition = transform.position.y + 10;
        despawnYPosition = transform.position.y - 10;
    }

    private void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnInterval)
        {
            timeSinceLastSpawn = 0;

            GameObject milk = Instantiate(milkPrefab, new Vector2(spawnXPosition, spawnYPosition), Quaternion.identity);
            milk.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -10);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Milk")
        {
            Destroy(collision.gameObject);
        }
    }
}
