using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGoOffice : MonoBehaviour
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

            startPosition = startPosition + new Vector3(0, 1, 0);
            distance = officePosition - startPosition;
            print("The distance to cover is " + distance);
            float finalDistance = distance.magnitude;
            if (finalDistance < 0)
            {
                print("Please press downarrow to move backward");
            }
            else if (finalDistance > 0)
            {
                print("Please press uparrow to move forward");
            }
            else if (finalDistance == 0)
            {
                print("You reached office");
            }

        }


        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            startPosition = startPosition + new Vector3(0, -1, 0);
            distance = officePosition - startPosition;
            print("The distance to cover is " + distance);
            float finalDistance = distance.magnitude;
            /*if (finalDistance < 0)
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
            }*/

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            startPosition = startPosition + new Vector3(1, 0, 0);
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
            startPosition = startPosition + new Vector3(-1, 0, 0);
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

        if (Input.GetKeyDown(KeyCode.RightAlt))
        {

            startPosition = startPosition + new Vector3(0, 0, 1);
            distance = officePosition - startPosition;
            print("The distance to cover is " + distance);
            float finalDistance = distance.magnitude;
            if (finalDistance < 0)
            {
                print("Please press Left alt to move backward");
            }
            else if (finalDistance > 0)
            {
                print("Please press Right alt to move forward");
            }
            else if (finalDistance == 0)
            {
                print("You reached office");
            }

        }
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            startPosition = startPosition + new Vector3(0, 0, -1);
            distance = officePosition - startPosition;
            print("The distance to cover is " + distance);
            float finalDistance = distance.magnitude;
            if (finalDistance < 0)
            {
                print("Please press Left alt move backward");
            }
            else if (finalDistance > 0)
            {
                print("Please press Right alt forward");
            }

            else if (finalDistance == 0)
            {
                print("You reached office");
            }

        }





    }
}


