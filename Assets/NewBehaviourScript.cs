using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class NewBehaviourScript : MonoBehaviour
{
    public LineRenderer LineRenderer;
    public GameObject TreeNode0;
    public GameObject TreeNode1;
    public GameObject TreeNode2;
    public GameObject TreeNode3;
    public GameObject TreeNode4;
    public GameObject TreeNode5;
    public GameObject TreeNode6;
    public string input;    
    public TextMeshProUGUI inputField;
    
    List<GameObject> unityGameObjects = new List<GameObject>();
    int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        unityGameObjects.Add(TreeNode0);
        unityGameObjects.Add(TreeNode1);
        unityGameObjects.Add(TreeNode2);
        unityGameObjects.Add(TreeNode3);
        unityGameObjects.Add(TreeNode4);
        unityGameObjects.Add(TreeNode5);
        unityGameObjects.Add(TreeNode6);
        Debug.Log(unityGameObjects);  
        Debug.Log(unityGameObjects.Count);
        Debug.Log("hello world");
        LineRenderer.startColor = Color.red;
        LineRenderer.endColor = Color.red;

        // set width of the renderer
        LineRenderer.startWidth = 0.3f;
        LineRenderer.endWidth = 0.3f;
        Vector3 linePosi1 = new Vector3(0,4,1);
        Vector3 linePosi2 = new Vector3(-2,2,1);


        // LineRenderer.SetPosition(0,TreeNode0.transform.position);
        // LineRenderer.SetPosition(1,TreeNode1.transform.position); 
        // otherGameObject.GetComponent<HingeJoint>()

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            if(index < 7){
                unityGameObjects[index].SetActive(true);
                unityGameObjects[index].GetComponentInChildren<TextMeshPro>().text = input.ToString();
                index++;
            }
             
            // if(index == 1 || index == 2){
            //     LineRenderer.SetPosition(0, unityGameObjects[0].Position);
            //     LineRenderer.SetPosition(1, unityGameObjects[index].Position);
            // }
           
            
        }
        LineRenderer.SetPosition(0,TreeNode0.transform.position);
        LineRenderer.SetPosition(1,TreeNode1.transform.position);

        
    }
    public void GetInput(string s){
        input = s;
        Debug.Log(s);
    }

}
