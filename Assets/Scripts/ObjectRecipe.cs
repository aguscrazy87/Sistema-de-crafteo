using UnityEngine;
[CreateAssetMenu(fileName = "NewRecipe", menuName = "Custom/CraftingRecipies")]
public class ObjectRecipe : ScriptableObject
{
    public int ID;
    public string recipe;
    /// <summary>
    /// Esta funcion regresa un valor ID para que funciona para encender el boton del objeto correspondiente creado por la receta
    /// </summary>
    /// <returns></returns>
    public int getObjectID()
    { return ID; }
    /// <summary>
    /// Esta funcion regresa el codigo numerico que permite crear esta receta
    /// </summary>
    /// <returns></returns>
    public string getRecipe()
    { return recipe; }
}
