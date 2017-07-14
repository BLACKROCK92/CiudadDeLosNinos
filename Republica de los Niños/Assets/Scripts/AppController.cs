using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppController : MonoBehaviour {

    #region Atributos
    [SerializeField]
    GameObject InstruccionesCanvas;
    [SerializeField]
    GameObject mainCamera;
    [SerializeField]
    GameObject ARCamera;
    #endregion

    public void DesactivarInstrucciones()
    {
        mainCamera.SetActive(false);
        InstruccionesCanvas.SetActive(false);
        ARCamera.SetActive(true);
    }

    public void ActivarInstrucciones()
    {
        ARCamera.SetActive(false);
        InstruccionesCanvas.SetActive(true);
        mainCamera.SetActive(true);
    }


}
