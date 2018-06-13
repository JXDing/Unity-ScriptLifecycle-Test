using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    #region Initialization
    void Awake()
    {
        Debug.Log("Awake() -- S2 --" + this.name);
    }
  
    void OnEnable()
    {
        Debug.Log("OnEnable() -- S2 --" + this.name);     
    }

    void Start()
    {
        Debug.Log("Start() -- S2 --" + this.name);
    }
    #endregion


    #region Editor
    void Reset()
    {
        Debug.Log("Reset() -- S2 --" + this.name);
    }
    #endregion


    #region 3Update
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate() -- S2 --" + this.name);        
    }

    void Update()
    {
        Debug.Log("Update() -- S2 --" + this.name);
    }//Update_end  

    void LateUpdate()
    {
        Debug.Log("LateUpdate() -- S2 --" + this.name);
    }

    IEnumerable TestCoroutine()
    {
        yield return new WaitForSeconds(0.1f);
        Debug.Log("TestCoroutine -- S2 --" + this.name);
        while (true)
        {
            yield return new WaitForSeconds(0.1f);            
        }
    }
    #endregion


    #region View
    void OnGUI()
    {
        Debug.Log("OnGUI() -- S2 --" + this.name);
    }
    
    #endregion
    

    void OnDisable()
    {
        Debug.Log("OnDisable() -- S2 --" + this.name);
        StopCoroutine("TestConrution");
    }

    void OnDestroy()
    {
        Debug.Log("OnDestroy() -- S2 --" + this.name);
    }

}
