using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deaths : MonoBehaviour {
    Text deaths;
    private Player player;
    // Use this for initialization
    void Start()
    {
        deaths = GetComponent<Text>();
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        deaths.text = "Deaths: " + player.deaths;
    }
}
