using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class circularqueue2 : MonoBehaviour
{
    List<GameObject> unityGameObjects = new List<GameObject>();
    List<Vector3> posi = new List<Vector3>();
    public GameObject node0;
    public GameObject node1;
    public GameObject node2;
    public GameObject node3;
    public GameObject node4;
    public GameObject node5;
    public GameObject node6;
    public GameObject node7;
    public string input;    
    public TextMeshProUGUI inputField;
    public TextMeshProUGUI overflowtext;
    public TextMeshProUGUI underflowtext;
    // public TextMeshProUGUI fronttext;
    public Text pushCode;
    public Text overFlow;
    public Text popCode;
    public Text underFlow;
    public Material materialrear;
    public Material materialfront;
    public Material materialred;


    int count = 0;
    int max = 8;
    int front = 0;
    int rear = -1;


    void Start()
    {
        unityGameObjects.Add(node0);
        unityGameObjects.Add(node1);
        unityGameObjects.Add(node2);
        unityGameObjects.Add(node3);
        unityGameObjects.Add(node4);
        unityGameObjects.Add(node5);
        unityGameObjects.Add(node6);
        unityGameObjects.Add(node7);
        posi.Add(new Vector3(0,0,0));

    }

    // Update is called once per frame
    void Update(){
        
        if(Input.GetKeyDown(KeyCode.Space)){
            if(count == max){
                overflowtext.text = "Overflow!!";
                popCode.color = Color.white;
                underFlow.color = Color.white;
                pushCode.color = Color.white;
                overFlow.color = Color.green;
                Debug.Log("Overflow");
            }else{
                
                popCode.color = Color.white;
                underFlow.color = Color.white;
                pushCode.color = Color.green;
                overFlow.color = Color.white;
                overflowtext.text = " ";
                underflowtext.text = " ";
                rear = (rear+1) % max;
                if(count == 0){
                    unityGameObjects[rear].GetComponent<Renderer>().material = materialrear;
                }else{
                    
                    unityGameObjects[((rear+7)%max)].GetComponent<Renderer>().material = materialred;
                    unityGameObjects[rear].GetComponent<Renderer>().material = materialrear;
                    unityGameObjects[front].GetComponent<Renderer>().material = materialfront;

                }
                unityGameObjects[rear].GetComponentInChildren<TextMeshPro>().text = input.ToString();
                count++;
            }
        }
        if(Input.GetKeyDown(KeyCode.F)){
            if(count == 0){
                popCode.color = Color.white;
                underFlow.color = Color.green;
                pushCode.color = Color.white;
                overFlow.color = Color.white;
                underflowtext.text = "Underflow!!";
                Debug.Log("underflow");
            }else{
                popCode.color = Color.green;
                underFlow.color = Color.white;
                pushCode.color = Color.white;
                overFlow.color = Color.white;
                overflowtext.text = " ";
                underflowtext.text = " ";
                unityGameObjects[front].GetComponentInChildren<TextMeshPro>().text = "";
                front = (front+1) % max;
                unityGameObjects[((front+7)%max)].GetComponent<Renderer>().material = materialred;
                unityGameObjects[front].GetComponent<Renderer>().material = materialfront;
                count--;    
            }
        }

    }
    public void GetInput(string s){
        input = s;
        Debug.Log(s);
    }
    public void Insert(){
        if(count == max){
            overflowtext.text = "Overflow!!";
            popCode.color = Color.white;
            underFlow.color = Color.white;
            pushCode.color = Color.white;
            overFlow.color = Color.green;
            Debug.Log("Overflow");
        }else{
                
            popCode.color = Color.white;
            underFlow.color = Color.white;
            pushCode.color = Color.green;
            overFlow.color = Color.white;
            overflowtext.text = " ";
            underflowtext.text = " ";
            rear = (rear+1) % max;
            if(count == 0){
                    unityGameObjects[rear].GetComponent<Renderer>().material = materialrear;
                }else{
                    
                    unityGameObjects[((rear+7)%max)].GetComponent<Renderer>().material = materialred;
                    unityGameObjects[rear].GetComponent<Renderer>().material = materialrear;
                    unityGameObjects[front].GetComponent<Renderer>().material = materialfront;

                }
            unityGameObjects[rear].GetComponentInChildren<TextMeshPro>().text = input.ToString();
            count++;
        }
        
    }
    public void Delete(){
        if(count == 0){
            popCode.color = Color.white;
            underFlow.color = Color.green;
            pushCode.color = Color.white;
            overFlow.color = Color.white;
            underflowtext.text = "Underflow!!";
            Debug.Log("underflow");
        }else{
            popCode.color = Color.green;
            underFlow.color = Color.white;
            pushCode.color = Color.white;
            overFlow.color = Color.white;
            overflowtext.text = " ";
            underflowtext.text = " ";
            unityGameObjects[front].GetComponentInChildren<TextMeshPro>().text = "";
            front = (front+1) % max;
            unityGameObjects[((front+7)%max)].GetComponent<Renderer>().material = materialred;
            unityGameObjects[front].GetComponent<Renderer>().material = materialfront;
            count--;
        }
    }
}
