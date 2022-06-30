using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    [SerializeField] private GameObject details;
    public void toggleOn()
    {
        details.gameObject.SetActive(!details.gameObject.activeSelf);
    }
}
