using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QueueScript : MonoBehaviour
{
    
    public GameObject spawnObject;
    public GameObject plane;
    public TextMeshPro num;
    public Text textElement;
    // public InputField myInput;
    public string input;    

    public Text pushCode;
    public Text overFlow;
    public Text popCode;
    public Text underFlow;


    GameObject[] arr = new GameObject[5];
    int count = 0;
    int top = 0;
    float initial = -0.5f;
    int number = 1;


    // Update is called once per frame
    void Update()
    {
        Physics2D.gravity = new Vector2(-9.81f,0);
        // if(mainInputField)

         if(Input.GetKeyDown(KeyCode.Space)){
            if(count <= 3){
                textElement.text = "";
                pushCode.color = Color.green;
                overFlow.color = Color.white;
                popCode.color = Color.white;
                underFlow.color = Color.white;
                Vector3 spawnPosition = new Vector3(5,1,0);
                arr[count] = Instantiate(spawnObject,spawnPosition,Quaternion.identity);
                arr[count].GetComponentInChildren<TextMeshPro>().text = input.ToString();
                count++;
                number++;
            }else{
                popCode.color = Color.white;
                underFlow.color = Color.white;
                pushCode.color = Color.white;
                overFlow.color = Color.green;
                textElement.text = "OverFlow!";
                // myInput.text = "";

            }
            
            
         }
         else if(Input.GetKeyDown(KeyCode.F)){
            if(top < count){
                // Vector3 movement = new Vector3(0.5f,0,0);
                Destroy(arr[top]);
                textElement.text = "";
                pushCode.color = Color.white;
                overFlow.color = Color.white;
                popCode.color = Color.green;
                underFlow.color = Color.white;
                // plane = transform.Translate(movement);
                initial+=1;
                plane.transform.position = new Vector3(initial,1,0);
                top++;
            }else{
                pushCode.color = Color.white;
                overFlow.color = Color.white;
                popCode.color = Color.white;
                underFlow.color = Color.green;
                textElement.text = "Underflow!";
            }
           
         }
        
    }
    

    public void Enqueue(){
        if(count <= 3){
            textElement.text = "";
            pushCode.color = Color.green;
            overFlow.color = Color.white;
            popCode.color = Color.white;
            underFlow.color = Color.white;
            Vector3 spawnPosition = new Vector3(5,1,0);
            arr[count] = Instantiate(spawnObject,spawnPosition,Quaternion.identity);
            arr[count].GetComponentInChildren<TextMeshPro>().text = input.ToString();
            count++;
            number++;
        }else{
            popCode.color = Color.white;
            underFlow.color = Color.white;
            pushCode.color = Color.white;
            overFlow.color = Color.green;
            textElement.text = "OverFlow!";
                // myInput.text = "";

        }
    }

    public void Dequeue(){
        if(top < count){
                // Vector3 movement = new Vector3(0.5f,0,0);
            Destroy(arr[top]);
            textElement.text = "";
            pushCode.color = Color.white;
            overFlow.color = Color.white;
            popCode.color = Color.green;
            underFlow.color = Color.white;
                // plane = transform.Translate(movement);
            initial+=1;
            plane.transform.position = new Vector3(initial,1,0);
            top++;
        }else{
               
            pushCode.color = Color.white;
            overFlow.color = Color.white;
            popCode.color = Color.white;
            underFlow.color = Color.green;
            textElement.text = "Underflow!";
        }
    }
    public void GetInput(string s){
        input = s;
        Debug.Log(s);
    } 
}
