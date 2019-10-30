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
        taskStrings[0] = "Task 0: Remove panel";
        taskStrings[1] = "Task 1: Unscrew things";
        taskStrings[2] = "Task 2: Remove old ram";
        taskStrings[3] = "Task 3: Put in new ram";
        taskStrings[4] = "Task 4";
        taskStrings[5] = "Task 5";
        taskStrings[6] = "Task 6";
        taskStrings[7] = "Task 7";
        taskStrings[8] = "Task 8";
        taskStrings[9] = "Task 9";
        taskStrings[10] = "Task 10";
        taskStrings[11] = "Task 11";
        taskStrings[12] = "Task 12";
        taskStrings[13] = "Task 13";
        taskStrings[14] = "Task 14";
        taskStrings[15] = "Task 15";

        currentTaskNum = 0;
        taskText.text = taskStrings[currentTaskNum];
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
