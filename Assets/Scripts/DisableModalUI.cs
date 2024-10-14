using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableModalUI : MonoBehaviour
{
    void Start()
    {
        GameObject modalUI = GameObject.Find("ModalUI");

        if (modalUI != null)
        {
            modalUI.SetActive(false); 
        }
        else
        {
            Debug.LogWarning("ModalUI не знайдено в сцені.");
        }
    }
}
