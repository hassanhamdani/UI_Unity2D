using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitGame : MonoBehaviour
{
   public void Exit()
    {
       Debug.Log("Exiting Game...");
        Application.Quit();
    }

}
