using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoOfficeVector3 : MonoBehaviour
{
    public Vector3 startPosition;
    [SerializeField]
    private Vector3 officePosition;
    private Vector3 distance;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello! Welcome to my game GoOffice");
        print("How to play the game?");
        print("Press up arrow to move forward \n press down arrow to move backward");
        print("My start position is " + startPosition);
        print("My office position is " + officePosition);
        distance = officePosition - startPosition;
        print("The distance to cover is " + distance);
     
    }

    // Update is called once per frame
    void Update()
    {

        //print("Im in update function");
        CheckPlayerMoment(KeyCode.UpArrow, new Vector3(0, 1, 0));
        CheckPlayerMoment(KeyCode.DownArrow, new Vector3(0, -1, 0));
        CheckPlayerMoment(KeyCode.RightArrow, new Vector3(1, 0, 0));
        CheckPlayerMoment(KeyCode.LeftArrow, new Vector3(-1, 0,0));
        CheckPlayerMoment(KeyCode.RightArrow, new Vector3(0, 0, 1));
        CheckPlayerMoment(KeyCode.LeftArrow, new Vector3(0,0,-1));
    }
   


    

    private void CheckPlayerMoment(KeyCode arrow, Vector3 value)
    {
        

            startPosition = startPosition + value;
            distance = officePosition - startPosition;
            print("The distance to cover is " + distance);

            if (startPosition == officePosition)
            {
                print("You reached office");
            }

        
    }
}

