using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    private int health = 100;
    public void damage(int value)
    {
        if(health >= value)
        {
            health -= value;

        }
        else
        {
            isGameOver = true;
        }
    }
    public void fix(int value)
    {
        if(health < 100)
        
            health += value;
        if(health > 100)
        {
            health = 100;
        }

    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (isGameOver)
        {
            Debug.Log("Game Over");
            //Destroy(player);
            player.SetActive = false;
        }
	}
}
