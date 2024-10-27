using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigate : MonoBehaviour
{
    public void OpenRiver(){
        SceneManager.LoadScene("SampleScene");
    }

    public void OpenState(){
        SceneManager.LoadScene("state");
    }
    
    public void OpenInstruct(){
        SceneManager.LoadScene("InstructScreen");
    }
    
}
