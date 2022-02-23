using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoOffice : MonoBehaviour
{
    public Vector2 startPosition;
    [SerializeField]
    private Vector2 officePosition;
    private Vector2 distance;
 
    // Start is called before the first frame update
    void Start()
    {
        print("Hello! Welcome to my game GoOffice");
        print("How to play the game?");
        print("Press up arrow to move forward \n press down arrow to move backward");
        print("My start position is " + startPosition);
        print("My office position is " + officePosition);
       distance = officePosition - startPosition;
        print("The distance to cover is " + distance.magnitude);
        float finalDistance = distance.magnitude;
        if (finalDistance > 0)
            print("Move forward");
        else if (finalDistance < 0)
            print("Move Backward");
        else if (finalDistance == 0)
            print("You reached your destination");
  }

    // Update is called once per frame
    void Update()
    {
        //print("Im in update function");
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            startPosition = startPosition+ new Vector2(0, 1);
            distance = officePosition - startPosition;
            print("The distance to cover is " + distance);
            float finalDistance = distance.magnitude;
            if (finalDistance<0)
            {
                print("Please press down arrow to move backward");
            }
            else if (finalDistance>0)
            {
                print("Please press up arrow to move forward");
            }
             else if (finalDistance==0)
            {
                print("You reached office");
            }

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            startPosition = startPosition + new Vector2(0, -1);
            distance = officePosition - startPosition;
            print("The distance to cover is " + distance);
            float finalDistance = distance.magnitude;
            if (finalDistance < 0)
            {
                print("Please press down arrow to move backward");
            }
            else if (finalDistance > 0)
            {
                print("Please press top arrow to move forward");
            }
 
            else if (finalDistance == 0)
            {
                print("You reached office");
            }

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            startPosition = startPosition + new Vector2(1, 0);
            distance = officePosition - startPosition;
            print("The distance to cover is " + distance);
            float finalDistance = distance.magnitude;
            if (finalDistance < 0)
            {
                print("Please press left arrow to move backward");
            }
            else if (finalDistance > 0)
            {
                print("Please press right arrow to move forward");
            }
            else if (finalDistance == 0)
            {
                print("You reached office");
            }

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            startPosition = startPosition + new Vector2(-1, 0);
            distance = officePosition - startPosition;
            print("The distance to cover is " + distance);
            float finalDistance = distance.magnitude;
            if (finalDistance < 0)
            {
                print("Please press left arrow to move backward");
            }
            else if (finalDistance > 0)
            {
                print("Please press right arrow to move forward");
            }

            else if (finalDistance == 0)
            {
                print("You reached office");
            }

        }



    }
}
