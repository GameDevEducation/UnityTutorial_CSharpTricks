using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchesDemo : MonoBehaviour
{
    public enum EDirection
    {
        North,
        East,
        South,
        West
    }

    public static Vector3 DirectionToVector(EDirection direction) => direction switch
    {
        EDirection.North => Vector3.forward,
        EDirection.East => Vector3.right,
        EDirection.South => -Vector3.forward,
        EDirection.West => -Vector3.right,
        _ => throw new System.ArgumentOutOfRangeException($"Unknown direction {direction}")
    };

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(DirectionToVector(EDirection.North));

        int diceRoll = Random.Range(1, 21);

        Debug.Log($"Dice roll was {diceRoll}");

        switch(diceRoll)
        {
            case 1:
                Debug.Log("Critical Fail");
                break;

            case 20:
                Debug.Log("Critical Success");
                break;

            case <= 5:
                Debug.Log("Outcome 1");
                break;

            case < 10:
            case > 18:
                Debug.Log("Outcome 2");
                    break;

            default:
                Debug.Log("Default!");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
