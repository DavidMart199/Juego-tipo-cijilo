using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viguilante : MonoBehaviour
{

    public float putinSpeed;
    public int direccion = 1;
    public int rotationM = 1;
    bool cambioDeDireccionNeg = true;
    bool cambioDeDireccionPos = false;


   


    private void Update()
    {
        transform.position += new Vector3(0, 0, putinSpeed * Time.deltaTime * direccion);

        if (cambioDeDireccionNeg == false && cambioDeDireccionPos == true)// dir negativa
        {
            direccion = -1;
     
        }
        if (cambioDeDireccionPos == false && cambioDeDireccionNeg == true) // dir positiva
        {
            direccion = 1;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "punto")
        {
            cambioDeDireccionNeg = false;
            cambioDeDireccionPos = true;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (other.transform.tag == "punto1")
        {
            cambioDeDireccionNeg = true;
            cambioDeDireccionPos = false;
            transform.rotation = Quaternion.Euler(0, 0, 0);

        }
    }
}
