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
    void Start()
    {
        
    }
    /// <summary>
    /// Transforma los valores del array TableTiles a un string con todos los valores a una serie numerica
    /// </summary>
    public void SetRecipe()
    {
        recipeToCheck = string.Empty;
        for (int i = 0; i <= TableTiles.Length; i++)
        {
            recipeToCheck += TableTiles[i].ToString();
        }
    }
    /// <summary>
    /// Revisa si alguno de los scriptableobjects en el array contiene esa receta
    /// </summary>
    public void CheckCraft()
    {

    }
    /// <summary>
    /// Craftea el objeto si la receta existe activando su boton correspondiente en el inventario de objetos
    /// </summary>
    /// <returns></returns>
    public int CraftObject()
    {
        return 0;
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
        for(int i = 0; i <= TableTiles.Length; i++)
        {
            TableTiles[i] = 0;
        }
    }
}
