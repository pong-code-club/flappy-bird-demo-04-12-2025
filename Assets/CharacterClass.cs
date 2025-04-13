using UnityEngine;

//4 main ideas of coding

//#1 Variables - data that you can keep track of in a game
//player score, player health, player mana

//#2 Function - recipes for actions you can do in a game
//attack, walk, run, jump

//#3 Rules/Conditional Logic - If something is true, then do something

//#4 Classes - A way to represent real world objects
//Container for Variables, Functions and Rules

//=====================================================================

//What are we trying to do with Unity and Game Development
//#1 Move/Rotate/Scale objects through code
//#2 Add/Remove objects when the game is running
//#3 Keep track of stats (health power, score, current level)
//#4 Detect Collisions
//#5 Do something only when some condition is true

public class CharacterClass : MonoBehaviour
{
    //declared variables
    public int PlayerScore;
    public int PlayerHealth;
    public float PlayerSpeed;
    public string PlayerName;
    public bool IsPlayerAlive;

    //declared functions
    void TakeDamage()
    {
        PlayerHealth = PlayerHealth - 1;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit something");
        //PlayerHealth = PlayerHealth - 1;

        if (collision.gameObject.name == "Boss")
        {
            //PlayerHealth = PlayerHealth - 1;
            TakeDamage();
        }

        if (collision.gameObject.name == "Coin")
        {
            PlayerScore = PlayerScore + 10;
        }
    }
}
