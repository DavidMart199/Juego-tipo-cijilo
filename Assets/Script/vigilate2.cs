using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vigilate2 : MonoBehaviour
{

    public float putinSpeed;
    public int direccion = 1;
    public int rotationM = 1;
    bool cambioDeDireccionNeg = false;
    bool cambioDeDireccionPos = true;

    private void Update()
    {
        transform.position += new Vector3(putinSpeed * Time.deltaTime * direccion, 0, 0);
      

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
            cambioDeDireccionNeg = true;
            cambioDeDireccionPos = false;
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        if (other.transform.tag == "punto1")
        {
            cambioDeDireccionNeg = false;
            cambioDeDireccionPos = true;
            transform.rotation = Quaternion.Euler(0, -90, 0);

        }
    }
}
