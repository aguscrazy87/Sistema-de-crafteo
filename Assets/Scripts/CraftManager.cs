using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class CraftManager : MonoBehaviour
{
    public ObjectRecipe[] recipiesArray;
    private string recipeToCheck;
    public List<Button> ButtonList;
    private int currentObject;
    public int[] TableTiles;
    public Inventory inventory;
    public int inventoryObjects;
    void Start()
    {
        inventoryObjects = inventory.GetObjectsOnList();
    }
    /// <summary>
    /// Transforma los valores del array TableTiles a un string con todos los valores a una serie numerica
    /// </summary>
    public void SetRecipe()
    {
        recipeToCheck = string.Empty;
        for (int i = 0; i < TableTiles.Length; i++)
        {
            recipeToCheck += TableTiles[i].ToString();
        }
        Debug.Log(recipeToCheck);
    }
    /// <summary>
    /// Revisa si alguno de los scriptableobjects en el array contiene esa receta
    /// </summary>
    public void CheckCraft()
    {
        for (int i = 0; i < recipiesArray.Length; i++)
        {
            if(recipeToCheck == recipiesArray[i].getRecipe() && inventoryObjects > recipiesArray[i].getObjectID())
            {
                CraftObject(recipiesArray[i].getObjectID());
                break;
            }
            else if(inventoryObjects > recipiesArray[i].getObjectID())
            {
                Debug.Log("Si hay objeto crafteable pero la receta es incorrecta");
            }
            else if (recipeToCheck == recipiesArray[i].getRecipe())
            {
                Debug.Log("La receta es correcta pero no hay un boton asignado");
            }
            else 
            {
                Debug.Log("No se pudo crear");
            }
        }
    }
    /// <summary>
    /// Craftea el objeto si la receta existe activando su boton correspondiente en el inventario de objetos
    /// </summary>
    /// <param name="id"></param>
    public void CraftObject(int id)
    {
        Debug.Log("Se mando a craftear");
        inventory.CraftObject(id);
        CleanTable();
    }
    /// <summary>
    /// Cambia el valor de una tile de la mesa de crafteo
    /// </summary>
    /// <param name="tileNumber"></param>
    public void SetTile(int tileNumber)
    {
        TableTiles[tileNumber] = currentObject;
        SetRecipe();
    }
    /// <summary>
    /// Selecciona el objeto que se agregara a la messa desde el inventario
    /// </summary>
    /// <param name="ingredient"></param>
    public void SelectCurrentObject(int ingredient)
    {
        currentObject = ingredient;
    }
    /// <summary>
    /// Limpia la mesa de objetos
    /// </summary>
    public void CleanTable()
    {
        for(int i = 0; i < TableTiles.Length; i++)
        {
            TableTiles[i] = 0;
        }
        SetRecipe();
    }
}