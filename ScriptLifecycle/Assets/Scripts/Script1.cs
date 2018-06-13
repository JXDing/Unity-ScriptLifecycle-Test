using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{

    #region Initialization
    void Awake()
    {
        Debug.Log("Awake() -- S1 --" + this.name);
    }

    void OnEnable()
    {
        Debug.Log("OnEnable() -- S1 --" + this.name);
    }

    void Start()
    {
        Debug.Log("Start() -- S1 --" + this.name);
    }
    #endregion


    #region Editor
    void Reset()
    {
        Debug.Log("Reset() -- S1 --" + this.name);
    }
    #endregion


    #region 3Update
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate() -- S1 --" + this.name);
    }

    void Update()
    {
        Debug.Log("Update() -- S1 --" + this.name);
    }//Update_end  

    void LateUpdate()
    {
        Debug.Log("LateUpdate() -- S1 --" + this.name);
    }

    IEnumerable TestCoroutine()
    {
        yield return new WaitForSeconds(0.1f);
        Debug.Log("TestCoroutine -- S1 --" + this.name);
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
        }
    }
    #endregion


    #region View
    void OnGUI()
    {
        Debug.Log("OnGUI() -- S1 --" + this.name);
    }

    #endregion


    void OnDisable()
    {
        Debug.Log("OnDisable() -- S1 --" + this.name);
        StopCoroutine("TestConrution");
    }

    void OnDestroy()
    {
        Debug.Log("OnDestroy() -- S1 --" + this.name);
    }
}
