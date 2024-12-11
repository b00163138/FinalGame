using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    public float speed = 40.0f;

    // Reference to the player object
    public GameObject player;

    // Store the player's starting position
    private Vector3 playerStartPosition;

    // Start is called before the first frame update
    void Start()
    {
        // If player is not assigned, find the player by tag
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        // Store the player's initial position
        if (player != null)
        {
            playerStartPosition = player.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Move the bullet to the left relative to the object's local axes
        transform.Translate(transform.right * Time.deltaTime * speed);
    }

    // Collision detection with other 3D objects
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Destroy the player if hit by the bullet
            Destroy(other.gameObject); // Destroy the player
            Debug.Log("Player destroyed by Enemy_Blob_Boss bullet! Click the Pause Button to Restart the Game.");

            // After a short delay, respawn the player at the start position
            StartCoroutine(RespawnPlayer());
        }

        // Destroy the bullet in all cases after collision
        Destroy(gameObject);
    }

    // Coroutine to respawn the player after destruction
    private IEnumerator RespawnPlayer()
    {
        // Wait for a short time before respawning
        yield return new WaitForSeconds(1f); // Adjust delay as needed

        if (player != null)
        {
            // Instantiate the player at the start position (this assumes you have a player prefab assigned)
            Instantiate(player, playerStartPosition, Quaternion.identity);

            // Log respawn
            Debug.Log("Player respawned at start position!");
        }
    }
}
