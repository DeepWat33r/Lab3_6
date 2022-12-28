using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class UIManager : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] public Text LevelName;
    [SerializeField] public Text GemsCollected;
    [SerializeField] public Text PlayerColor;


    // Start is called before the first frame update
    void Start()
    {
        LevelName.text = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        GemsCollected.text = $"{player.GemCollected}";
        PlayerColor.text = player.ColorState.ColorName;
    }
}
