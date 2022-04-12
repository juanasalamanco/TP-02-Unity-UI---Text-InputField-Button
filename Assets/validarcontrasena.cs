using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class validarcontrasena : MonoBehaviour
{
    string contraseniaCorrecta;
    string contraseniaUsuario;
    public Text ingresoUsuario;
    public GameObject cartel;
    public Text textomsj;

    // Start is called before the first frame update
    void Start()
    {
        contraseniaCorrecta = "12345";
        cartel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void validarcontrasenia()
    {
        contraseniaUsuario = ingresoUsuario.text;

        if (contraseniaUsuario == contraseniaCorrecta)
        {
            cartel.SetActive(true);
            textomsj.text = "bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartel.SetActive(true);
            textomsj.text = "Contraseña incorrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }
}
