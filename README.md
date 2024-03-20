## FLY AIR

## BACK-END
Descripción: El proyecto tiene como propósito brindarle diferente información al usuario sobre vuelos a través de una interfaz web, con la ayuda del consumo de APIs.

## Instalación

La API "Api\_Flights" se ejecuta por defecto en el puerto 5154. Para cambiar el puerto y permitir su consumo, sigue los siguientes pasos:

- Accede al proyecto FlyDataAccess.
- Abre la carpeta FlyRepository y luego la clase llamada FlyDA.cs.
- Modifica la variable "PORT" según el puerto en el que esté ejecutándose la API "Api\_Flights".

La API "Api\_Flights" simula la API del problema 2. En la misma ruta mencionada anteriormente, también encontrarás una variable llamada "LEVEL", que se refiere al nivel con el que se está trabajando. En este caso, "1" corresponde a "Rutas múltiples", como se indica en el Problema 2 - Consumo REST API.

## Estructura

*Core*: Contiene la carpeta Models, que hace referencia al modelado de clases propuesto en el problema 1. Además, incluye otra carpeta llamada DTO, que contiene una clase con los campos necesarios para realizar la petición GET y llamar a la API.

*FlyBusiness*: Contiene una carpeta llamada "Services", que incluye la clase "JourneyServices.cs", encargada de obtener, buscar y procesar los datos.

*FlyDataAccess*: Contiene una carpeta llamada "FlyRepository" y posee una clase "FlyDA.cs", que básicamente lee los datos obtenidos de la API.

*Api\\_Flights:* Es la API que simula la API del problema 2.

*FlyWebAPI*: Es la API expuesta que consume la API Api\_Flights.



## FRONT END

El Front End de este proyecto se encuentra desarrollado en Angular 17.2.3

## Instalación

El proyecto se encuentra en la carpeta "FlyFrontend". Es importante tener en cuenta en qué puerto se encuentra ejecutándose la API "FlyWebAPI" para poder consumirla.

Para cambiar el puerto y permitir su consumo, sigue estos pasos:

- Accede a la carpeta "Service" ubicada en "src -> app".
- Modifica la variable "PORT" ingresando el número del puerto en el cual se está ejecutando la API.

## Estructura

El proyecto cuenta con un Service encargado de realizar el llamado y configuración de la API, y un componente HOME. Este componente contiene el código HTML, la lógica y los estilos CSS del proyecto.

## Interfaz web

Como indica el punto 2 del documento de la prueba 

“Tenga en cuenta que en cada consulta la respuesta es estática y no cambia en el tiempo.” 

Por lo tanto, Campos de entrada: Hay dos campos de entrada etiquetados como “Origen” y “Destino” donde los usuarios pueden ingresar sus lugares de partida y llegada respectivamente los datos que acepta son:

MZL, BOG, BCN, MIA, NYC, LIM, SAO
