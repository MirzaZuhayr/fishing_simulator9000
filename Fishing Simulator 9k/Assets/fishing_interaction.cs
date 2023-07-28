using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class fishing_interaction : MonoBehaviour
{   
    public Text NumberText; 
    public Button fishButton;
    public void ButtonAction(){
        GenerateNumber(); 
    }
    public void GenerateNumber() {
        int random_number = Random.Range(1, 9);
        NumberText.text = random_number.ToString(); 
    }
}
