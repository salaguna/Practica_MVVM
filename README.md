# Practica_MVVM
Este ejemplo trata de sentar las bases y explicar la estructura de una aplicación diseñada con el patrón de arquitectura MVVM.

## OBJETIVO DE MVVM
El patrón MVVM busca la independencia entre la parte visual y la parte lógica.

## ESTRUCTURA
La aplicación se divide en 3 bloques diferenciados
* VIEW: Contiene la parte visual
* MODEL: Contriene el modelo de datos
* VIEWMODEL: Realiza la conexión entre la vista y el modelo.

La VIEW enlazará con el VIEWMODEL mediante **BINDINGS**, el cuál informará a la VIEW de los cambios a los que la vista solo tendrá que reacionar.
