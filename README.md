# Sistema-de-crafteo
Sistema de crafteo para examen de Ingenieria de software

PASOS DE CRAFTEO
1. Selecciona un objeto de tu inventario.
2. Coloca haciendo click en los espacios de la mesa de crafteo, puedes regresar al paso 1 para cambiar de objeto y colocar uno diferente en la mesa.
3. Da click en el boton "Craft".

Si la receta colocada en la mesa corresponde a un objeto crafteable este aparecera del lado del inventario, de lo contrario no ocurrira nada.

AGREGAR NUEVA RECETA
1. Crear un nuevo Scriptable Object (Create -> Custom -> CraftingRecipies).
2. Asignar el ID de boton a activar y su secuencia numerica de receta.
3. Añadir boton nuevo.
4. Asignar funcion de boton de inventario al nuevo boton (SelectCurrentObject).
5. Asignar un valor de item de receta al boton en esa funcion.
6. Añadir el scriptable Object a la lista de recetas del CraftManager.
- Para la rama interfaz y visuales -
7. Agregar un Sprite en la lista de Sprites en el Craft Manager acorde al numero de item de receta.
8. Añadir el sprite al boton en el inventario (Opcional).

LISTA DE OBJETOS EN EL INVENTARIO (ID DE ACTIVACION)
0. Wood (Activo)
1. Wood Planks (Bloqueado)
2. Sticks (Bloqueado)
3. Spear (Bloqueado)
4. Shovel (Bloqueado)
5. Boat (Bloqueado)

VALOR DE ITEM DE RECETA (POR DEFAULT)
0. Vacio 
1. Wood 
2. Wood Planks 
3. Sticks 
4. Spear 
5. Shovel 
6. Boat 

LISTA DE RECETAS 012 345 678
1. Wood planks = 000 010 000
2. Sticks ====== 000 020 020
3. Spear ======= 002 030 300
4. Shovel ====== 020 030 030
5. Boat ======== 000 252 222

DISTRIBUCION DE MESA
    0|1|2
    3|4|5
    6|7|8