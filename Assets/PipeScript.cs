using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public GameObject MyBirdGameObject;
    public Transform MyTransform;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MyTransform = GetComponent<Transform>();
        MyBirdGameObject = GameObject.Find("Bird");
    }

    // Update is called once per frame
    void Update()
    {
        if (MyBirdGameObject.transform.position.x - MyTransform.position.x > 10)
        {
            MyTransform.position = MyTransform.position + new Vector3(15, 0, 0);
        }
        
    }
}
