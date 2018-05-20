using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour {

    private Player player;

    // Use this for initialization
    void Start () {
        player = FindObjectOfType<Player>();
    }

    public void PressLeftArrow()
    {
        player.moveRight = false;
        player.moveLeft = true;
    }
    public void PressRightArrow()
    {
        player.moveRight = true;
        player.moveLeft = false;
    }
    public void ReleaseLeftArrow()
    {
        player.moveLeft = false;
    }
    public void ReleaseRightArrow()
    {
        player.moveRight = false;
    }
    public void Jump()
    {
        player.jump();
    }
    // Update is called once per frame
    void Update () {
		
	}
}
