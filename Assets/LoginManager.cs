using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LoginManager : MonoBehaviour
{

    public InputField inputPassword;
    public string contraCorrecta = "PepeCrack";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CheckPassword()
    {
        if(inputPassword.text == contraCorrecta)
        {
            Debug.Log("Acces Granted");

           
        }
        else
        {
            Debug.Log("Acces denied");
        }
    }
}
