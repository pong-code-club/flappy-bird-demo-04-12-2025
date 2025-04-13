using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdScript : MonoBehaviour
{
    //primitive variables
    public int BirdScore;
    public float BirdSpeed;
    public bool IsBirdAlive;
    public string BirdName;

    //compound variables
    public Transform MyTransform;
    public Rigidbody MyRigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Make reference to rigid body component through code
        MyRigidbody = GetComponent<Rigidbody>();

        //MyTransform.position = new Vector3(5, 0, 0);
        //MyTransform.position = MyTransform.position + new Vector3(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log("Pressing Up Button");
        //Debug.Log("is this working");
        //MyTransform.position = MyTransform.position + new Vector3(0.01f, 0, 0);
        MyTransform.position = MyTransform.position + new Vector3(3 * Time.deltaTime, 0, 0);

        /*if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("hit space bar");
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Pressing Up Button");
        }*/

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed Mouse Button");
            MyRigidbody.linearVelocity = new Vector3(0, 0, 0);
            MyRigidbody.AddForce(0,300,0);
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("FlappyBirdExample");
    }

}
