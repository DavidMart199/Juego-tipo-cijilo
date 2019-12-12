using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject winner, boton;
    float speed = 1;
    public static Vector3 pos;
    bool inGame=true;

    void Start()
    {
      /*  GameObject empty = new GameObject();
        empty.name = "Camera";
        empty.AddComponent<Camera>();
        empty.AddComponent<GiraCam>();
        empty.transform.SetParent(transform);
       // empty.transform.localPosition = new Vector3(0,0.52f,0.26f) ;
       // empty.transform.Rotate(20,0,0);
        this.gameObject.GetComponent<Rigidbody>();*/

    }
    void Update()
    {
        if (inGame == true)
        {
            MueveNave();

        }
    }
    void MueveNave()
    {
        transform.eulerAngles = new Vector3(0, GiraCam.rotY, 0);
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * (speed / 20);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * (speed / 20);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * (speed / 20);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * (speed / 20);
        }
        pos = transform.position;
    }
   public void ResetGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "winner")
        {
            winner.SetActive(true);
            boton.SetActive(true);
            inGame = false;
            
        }
    }

}
