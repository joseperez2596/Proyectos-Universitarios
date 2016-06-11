El proyecto esta hecho usando una arquitectura por capas.... no es la gran cosa solo se divide en partes xD

CAD- Capa de Acceso a Datos: aca ponemos los servicios que nos permiten acceder a los datos. Deben seguir las interfaces creadas en LN.
Portal: es la vista, usa las interfaces creadas en LN para obtener lo que sea que necesita. Los servicios creados aca solo los usa cada vista en particular, si puede ser reutilizado debe ir a LN o un proyecto de Ayuda (Helper).
LN- Logica de Negocio: aca tenemos todas las interfaces que usaremos para lograr que esto coja forma :P

La idea con esto es que las capas superiores no dependan de las inferiores. Por ejemplo, si el proyecto es tanto web como desktop, como todas las interfaces estan en BL puedo reutilizar todo el codigo tanto de base de datos
como los servicios core de la aplicacion porque aunque en LN no se implemente, si me dice ahi QUE es lo que se implementa.