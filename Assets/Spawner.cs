using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spherePrefab;
    public Button btn;
    // public string textValue;
    public Text textElement;
    public Text pushCode;
    public Text overFlow;

    public Text popCode;
    public Text underFlow;
    public TextMeshPro num;

    // public TextMeshPro textNumber;
    // public GameObject planePrefab;
    // Update is called once per frame
    int count = 0;
    int number = 1;
    GameObject[] arr = new GameObject[5];
    
    

    // Button Pushbtn = btn.GetComponent<Button>();
    
    void Update()
    {
        // double yCoordinate = -0.5; 
        // Input.GetKeyDown(KeyCode.Space)
        Button bb = btn.GetComponent<Button>();
        
        // Pushbtn.onClick.AddListener(Push);
        // btn.onClick.(Push());
        if(Input.GetKeyDown(KeyCode.Space)){
        
        // bb.onClick.AddListener(() => {
            // Vector3 spawnPositionOfPlane = new Vector3(0,(float)yCoordinate,1);
            // yCoordinate = yCoordinate + 1.1;
            // Instantiate(planePrefab, spawnPositionOfPlane, Quaternion.identity);
            if(count <= 3 && count >= 0){
                textElement.text = "";
                pushCode.color = Color.green;
                overFlow.color = Color.white;
                popCode.color = Color.white;
                underFlow.color = Color.white;
                
                
                Vector3 spawnPosition = new Vector3(0,6,1);
                // spherePrefab.GetComponentInChildren<Text>().text = number.ToString();
                arr[count] = Instantiate(spherePrefab, spawnPosition, Quaternion.identity);
                arr[count].GetComponentInChildren<TextMeshPro>().text = number.ToString();
                // num.text = "1"; 

                // spherePrefab.GetChild(0).GetComponent<TextMeshPro>().text = number.ToString();
                number++;
                count++;
            }else{
                popCode.color = Color.white;
                underFlow.color = Color.white;
                pushCode.color = Color.white;
                overFlow.color = Color.green;
                textElement.text = "Overflow!!";
                Debug.Log('o');
            }
        // });
        }
              
        if(Input.GetKeyDown(KeyCode.F)) {
            if(count > 0){
                textElement.text = "";
                pushCode.color = Color.white;
                overFlow.color = Color.white;
                popCode.color = Color.green;
                underFlow.color = Color.white;
                Destroy(arr[count-1]);
                arr[count] = null;
                count--;
                number--;
            }else{
                pushCode.color = Color.white;
                overFlow.color = Color.white;
                popCode.color = Color.white;
                underFlow.color = Color.green;
                textElement.text = "Underflow!!";
                Debug.Log('u');
            }
            
        }
        Debug.Log(count);
    }

    public void Push(){
        // Vector3 spawnPositionOfPlane = new Vector3(0,(float)yCoordinate,1);
            // yCoordinate = yCoordinate + 1.1;
            // Instantiate(planePrefab, spawnPositionOfPlane, Quaternion.identity);
            if(count <= 3 && count >= 0){
                textElement.text = "";
                pushCode.color = Color.green;
                overFlow.color = Color.white;
                popCode.color = Color.white;
                underFlow.color = Color.white;
                
                
                Vector3 spawnPosition = new Vector3(0,6,1);
                // spherePrefab.GetComponentInChildren<Text>().text = number.ToString();
                arr[count] = Instantiate(spherePrefab, spawnPosition, Quaternion.identity);
                arr[count].GetComponentInChildren<TextMeshPro>().text = number.ToString();
                // num.text = "1"; 

                // spherePrefab.GetChild(0).GetComponent<TextMeshPro>().text = number.ToString();
                number++;
                count++;
            }else{
                popCode.color = Color.white;
                underFlow.color = Color.white;
                pushCode.color = Color.white;
                overFlow.color = Color.green;
                textElement.text = "Overflow!!";
                Debug.Log('o');
            }
            
    }

    public void pop(){
        if(count > 0){
                textElement.text = "";
                pushCode.color = Color.white;
                overFlow.color = Color.white;
                popCode.color = Color.green;
                underFlow.color = Color.white;
                Destroy(arr[count-1]);
                arr[count] = null;
                count--;
                number--;
            }else{
                pushCode.color = Color.white;
                overFlow.color = Color.white;
                popCode.color = Color.white;
                underFlow.color = Color.green;
                textElement.text = "Underflow!!";
                Debug.Log('u');
            }
    }
}
