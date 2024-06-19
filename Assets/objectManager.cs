using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectManager : MonoBehaviour
{

    public GameObject[] objects;
    private int Index = 0; // Index of the corrent object

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject obj in objects)
        {
            obj.SetActive(false);
        }

        // Activate the first object
        if (objects.Length > 0)
        {
            objects[Index].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SwitchToNextObject();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SwitchToPreviousObject();
        }
    }

    void SwitchToNextObject()
    {
        // Deactivate the current object
        objects[Index].SetActive(false);

        Index = (Index + 1) % objects.Length;

        objects[Index].SetActive(true);
    }

    void SwitchToPreviousObject()
    {
        objects[Index].SetActive(false);

        Index = (Index - 1 + objects.Length) % objects.Length;

        objects[Index].SetActive(true);
    }
}
