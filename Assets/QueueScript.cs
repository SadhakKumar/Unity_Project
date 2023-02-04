using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QueueScript : MonoBehaviour
{
    
    public GameObject spawnObject;
    public GameObject plane;
    public TextMeshPro num;



    GameObject[] arr = new GameObject[5];
    int count = 0;
    int top = 0;
    float initial = -0.5f;
    int number = 1;


    // Update is called once per frame
    void Update()
    {
        Physics2D.gravity = new Vector2(-9.81f,0);

         if(Input.GetKeyDown(KeyCode.Space)){
            if(count <= 3){
                Vector3 spawnPosition = new Vector3(5,1,0);
                arr[count] = Instantiate(spawnObject,spawnPosition,Quaternion.identity);
                arr[count].GetComponentInChildren<TextMeshPro>().text = number.ToString();
                count++;
                number++;
            }
            
         }
         else if(Input.GetKeyDown(KeyCode.F)){
            if(top <= count){
                // Vector3 movement = new Vector3(0.5f,0,0);
                Destroy(arr[top]);
                // plane = transform.Translate(movement);
                initial+=1;
                plane.transform.position = new Vector3(initial,1,0);
                top++;
            }
           
         }
        
    }
}
