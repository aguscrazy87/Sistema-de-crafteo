using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    public List<GameObject> ObjectList;

    private void Start() //Desactivo todos para empezar a craftear con solo un obejto y desbloquear el resto
    {
        for(int i = 0; i < ObjectList.Count; i++)
        {
            ObjectList[i].SetActive(false);
        }

        ObjectList[0].SetActive(true);
    }
    /// <summary>
    /// Craftea el objeto desbloqueando su boton y permitiendo su uso
    /// </summary>
    /// <param name="id"></param>
    public void CraftObject(int id)
    {
        ObjectList[id].SetActive(true);
    }
    /// <summary>
    /// Manda la lista de objetos/materiales
    /// </summary>
    /// <returns></returns>
    public List<GameObject> GetObjectsOnList()
    {
        return ObjectList;
    }
}
