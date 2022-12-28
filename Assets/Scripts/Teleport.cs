using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Teleport : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] private string PlayerTag;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(PlayerTag) && player.GemCollected == 3)
            SceneManager.LoadScene("Level_2");
    }
}
