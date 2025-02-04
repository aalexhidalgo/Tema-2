using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    // Variable que guarda el sonido del vehiculo
    [SerializeField] private string sound = "�Brum, brum!";
    // Variable que guarda el nombre del vehiculo
    [SerializeField] private string name;
    // Variable que guarda el numero de ruedas del vehiculo
    [SerializeField] private int numberWheels = 4;
    // Variable que guarda si tiene sirena
    [SerializeField] private bool hasSiren;
    // Variable que indica si el veh�culo est� en marcha
    [SerializeField] private bool isOn = true;
    // Variable que indica la cantidad de gasolina
    [SerializeField] private float gasoline;


    // Start is called before the first frame update
    void Start()
    {
        /*Debug.Log($"Mensaje: {name} tiene {numberWheels} ruedas y hace {sound}");

        if (hasSiren)
        {
            Debug.Log($" {name} tiene sirena");
        }
        else
        {
            Debug.Log($" {name} no tiene sirena");
        }
        

        if (isOn == true)
        {
            Debug.Log($"{sound}");

        }else if (hasSiren == true)
        {
            Debug.Log($"{name} har� {sound} cuando se ponga en marcha");
        }
        else
        {
            Debug.Log($"{name} no est� en marcha");
        }
        */

        if (gasoline < 10 && isOn == true)
        {
            Debug.Log($"�A {name} le queda poca gasolina!");

            if (hasSiren == true)
            {
                Debug.Log($"{sound}");
            }
            else
            {
                Debug.Log($"{name} no tiene sirena");
            }
        }
        else
        {
            if (isOn == false)
            {
                Debug.Log($"{name} no est� en marcha.");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
