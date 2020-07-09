# Serviexpress

Esta parte del proyecto serviexpress está orientado a los clientes online del servicio

## Requerimientos

1. Primero debe descargar el .NET Framework(4.7.2) desde [Microsoft](https://dotnet.microsoft.com/download/dotnet-framework/thank-you/net472-developer-pack-offline-installer)
2. Después, debe descargas [Visual Studio Community 2019(Ultima version)](https://visualstudio.microsoft.com/es/vs/community/)
3. Por ultimo, debe descargar [SQLServer 2019](https://go.microsoft.com/fwlink/?linkid=866658)

### Proceso de instalación

1. Primero, instale en el orden indicado anteriormente las herramientas
2. Una vez que esté todo instalado, debe abrir SQLServer e ingresar sus credenciales [SQLServer Login](/InstruccionesREADME/loginSQL.png)

   1. Una vez aqui, haga click derecho en su "servidor", y seleccione [**Nueva query**](/InstruccionesREADME/nuevaQuery.png)
   2. Copie el siguiente codigo [Script SQL](/InstruccionesREADME/SERVIEXPRESS.sql) en la ventana que se acaba de abrir, y haga click en [**Execute**](/InstruccionesREADME/runScript.png)

   3. Siguiendo el mismo procedimiento del paso anterior, ejecute el siguiente [**Script**](/InstruccionesREADME/script_datos.sql) para poblarlas

3. Con [SQLServer] listo, tiene que instalar Visual Studio 2019.
   1. Una vez instalado, abralo, y seleccione la opción [**Open a project or solution**](/InstruccionesREADME/startupVS.png)


## Como iniciar el programa

1. Debe hacer click en el icono [**IIS Express**](/InstruccionesREADME/iniciarPrograma.png)
