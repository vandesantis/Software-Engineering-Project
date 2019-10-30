using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjectController : MonoBehaviour
{
    private int currentTaskNum;
    private int numTasks = 20;

    public Text taskText;
    private string[] taskStrings;

    // Start is called before the first frame update
    void Start()
    {
        taskStrings = new string[numTasks];
        taskStrings[0] = "Task 0";
        taskStrings[1] = "Task 1";
        taskStrings[2] = "Task 2";
        taskStrings[3] = "Task 3";

        currentTaskNum = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NextTask()
    {
        currentTaskNum++;
        taskText.text = taskStrings[currentTaskNum];
    }

    public void PrevTask()
    {
        if (currentTaskNum == 0)
        {
            return;
        }
        currentTaskNum--;
        taskText.text = taskStrings[currentTaskNum];
    }
}
