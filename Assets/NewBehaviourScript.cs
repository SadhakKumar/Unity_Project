using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class NewBehaviourScript : MonoBehaviour
{
    public LineRenderer line;
    public LineRenderer line2;
    public LineRenderer line3;
    public LineRenderer line4;
    public LineRenderer line5;
    public LineRenderer line6;
    public GameObject TreeNode0;
    public GameObject TreeNode1;
    public GameObject TreeNode2;
    public GameObject TreeNode3;
    public GameObject TreeNode4;
    public GameObject TreeNode5;
    public GameObject TreeNode6;
    public string input;    
    public TextMeshProUGUI inputField;
    public TextMeshProUGUI preordertext;
    public TextMeshProUGUI inordertext;
    public TextMeshProUGUI postordertext;

    public Material material;
    // public Transform posi1;
    // public Transform posi2;
    
    List<GameObject> unityGameObjects = new List<GameObject>();
    int index = 0;
    int z = 0;
    // Start is called before the first frame update
    void Start()
    {
        // line.enabled = false;
        // line2.enabled = false;
        // line3.enabled = false;
        // line4.enabled = false;
        // line5.enabled = false;
        // line6.enabled = false;
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
        // line.startColor = Color.blue;
        // line.endColor = Color.blue;

        // set width of the renderer
        // LineRenderer.startWidth = 0.3f;
        // LineRenderer.endWidth = 0.3f;
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
            if(index == 1){
                // line.enabled = true;
                line.material = material;

            }
            if(index == 2){   
                // line2.enabled = true;
                line2.material = material;

            }
            if(index == 3){
                line3.material = material;
                line3.enabled = true;
   
            }
            if(index == 4){
                line4.material = material;
                line4.enabled = true;
   
            }
            if(index == 5){
                line5.material = material;
                line5.enabled = true;
   
            }
            if(index == 6){
                line6.material = material;
                line6.enabled = true;
                // traversal();
   
            }
            if(index < 7){
                unityGameObjects[index].SetActive(true);
                unityGameObjects[index].GetComponentInChildren<TextMeshPro>().text = input.ToString();
                index++;
            }
             
            
           
            
        }
        // line.SetPosition(0,posi1.position);
        // line.SetPosition(1,posi2.position);

        
    }
    public void GetInput(string s){
        input = s;
        Debug.Log(s);
    }
    public void traversal(){
        string preorder = "";
        preorder += unityGameObjects[0].GetComponentInChildren<TextMeshPro>().text.ToString();
        preorder += unityGameObjects[1].GetComponentInChildren<TextMeshPro>().text.ToString();
        preorder += unityGameObjects[3].GetComponentInChildren<TextMeshPro>().text.ToString();
        preorder += unityGameObjects[4].GetComponentInChildren<TextMeshPro>().text.ToString();
        preorder += unityGameObjects[2].GetComponentInChildren<TextMeshPro>().text.ToString();
        preorder += unityGameObjects[5].GetComponentInChildren<TextMeshPro>().text.ToString();
        preorder += unityGameObjects[6].GetComponentInChildren<TextMeshPro>().text.ToString();
        preordertext.text += preorder;

        string inorder = "";
        inorder += unityGameObjects[3].GetComponentInChildren<TextMeshPro>().text.ToString();
        inorder += unityGameObjects[1].GetComponentInChildren<TextMeshPro>().text.ToString();
        inorder += unityGameObjects[4].GetComponentInChildren<TextMeshPro>().text.ToString();
        inorder += unityGameObjects[0].GetComponentInChildren<TextMeshPro>().text.ToString();
        inorder += unityGameObjects[5].GetComponentInChildren<TextMeshPro>().text.ToString();
        inorder += unityGameObjects[2].GetComponentInChildren<TextMeshPro>().text.ToString();
        inorder += unityGameObjects[6].GetComponentInChildren<TextMeshPro>().text.ToString();
        inordertext.text += inorder;


        string postorder = "";
        postorder += unityGameObjects[3].GetComponentInChildren<TextMeshPro>().text.ToString();
        postorder += unityGameObjects[4].GetComponentInChildren<TextMeshPro>().text.ToString();
        postorder += unityGameObjects[1].GetComponentInChildren<TextMeshPro>().text.ToString();
        postorder += unityGameObjects[5].GetComponentInChildren<TextMeshPro>().text.ToString();
        postorder += unityGameObjects[6].GetComponentInChildren<TextMeshPro>().text.ToString();
        postorder += unityGameObjects[2].GetComponentInChildren<TextMeshPro>().text.ToString();
        postorder += unityGameObjects[0].GetComponentInChildren<TextMeshPro>().text.ToString();
        postordertext.text += postorder;

    }
    public void Add(){
        
            if(index == 1){
                // line.enabled = true;
                line.material = material;

            }
            if(index == 2){   
                // line2.enabled = true;
                line2.material = material;

            }
            if(index == 3){
                line3.material = material;
                line3.enabled = true;
   
            }
            if(index == 4){
                line4.material = material;
                line4.enabled = true;
   
            }
            if(index == 5){
                line5.material = material;
                line5.enabled = true;
   
            }
            if(index == 6){
                line6.material = material;
                line6.enabled = true;
                // traversal();
   
            }
            if(index < 7){
                unityGameObjects[index].SetActive(true);
                unityGameObjects[index].GetComponentInChildren<TextMeshPro>().text = input.ToString();
                index++;
            }
             
            
           
            
        
    }

}
