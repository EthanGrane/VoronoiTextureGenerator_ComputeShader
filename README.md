<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Voronoi Texture Generator</title>
</head>
<body>

<h1>Voronoi Texture Generator using Compute Shader</h1>

<p>
    Este proyecto implementa un generador de texturas Voronoi utilizando Compute Shaders en Unity. 
    La función principal de este generador es crear texturas de ruido que pueden ser utilizadas en 
    shaders para mejorar visualmente los gráficos de los juegos y aplicaciones.
</p>

<h2>Características</h2>
<ul>
    <li>
        <strong>Tres modos de Voronoi:</strong>
        <ul>
            <li><strong>Greyscale</strong>: Genera texturas en escala de grises.</li>
            <img src="https://github.com/user-attachments/assets/46a84c5c-a61e-4f81-be2a-c4730db9eaf5" alt="Greyscale" width="300" />
            
            <li><strong>Floor</strong>: Crea patrones que simulan superficies de piso con opciones para intersecciones.</li>
            <img src="https://github.com/user-attachments/assets/1959d206-e534-4aa1-8b9c-5f204f2ee7fc" alt="Floor" width="300" />
            
            <li><strong>Crystal</strong>: Produce texturas con un efecto de cristal.</li>
            <img src="https://github.com/user-attachments/assets/16572c62-9d7d-4087-ae5f-0f4bc1637c48" alt="Diamond" width="300" />
        </ul>
    </li>
    <li>
        <strong>Configuración de parámetros:</strong>
        <ul>
            <li>Tamaño de textura: Configura el tamaño de la textura generada.</li>
            <li>Número de puntos: Establece la cantidad de puntos utilizados en el cálculo de la textura.</li>
            <li>Saturación: Controla la saturación del color de la textura generada.</li>
            <li>Tiled: Opción para repetir el patrón de textura en un modo de teselado.</li>
            <li>Colores invertidos: Permite invertir los colores de la textura.</li>
        </ul>
    </li>
    <li>
        <strong>Exportación de texturas:</strong> Posibilidad de exportar la textura generada a un archivo PNG.
    </li>
</ul>

<h2>Cómo usar</h2>
<ol>
    <li><strong>Agregar el script:</strong> Adjunta el script <code>VoronoiGenerator</code> a un GameObject en tu escena de Unity.</li>
    <li><strong>Configurar parámetros:</strong> Ajusta los parámetros en el inspector de Unity según tus necesidades.</li>
    <li><strong>Generar la textura:</strong> Haz clic en el botón "Generate" para crear la textura Voronoi.</li>
    <li><strong>Previsualizar la textura:</strong> La textura generada se mostrará en una vista previa en el inspector.</li>
    <li><strong>Exportar la textura:</strong> Utiliza el botón "Export Texture" para guardar la textura en tu sistema.</li>
</ol>

<h2>Dependencias</h2>
<ul>
    <li><strong>Unity:</strong> Este proyecto requiere Unity para su ejecución.</li>
    <li><strong>Compute Shaders:</strong> Asegúrate de que tu proyecto de Unity esté configurado para utilizar Compute Shaders.</li>
</ul>

<h2>Contribuciones</h2>
<p>
    Si deseas contribuir a este proyecto, siéntete libre de hacer un fork y enviar tus mejoras o sugerencias.
</p>

<h2>Licencia</h2>
<p>
    Este proyecto está bajo la Licencia MIT. Consulta el archivo <code>LICENSE</code> para obtener más detalles.
</p>

<h2>Capturas de pantalla</h2>
<img src="https://github.com/user-attachments/assets/29a83d1c-d81e-4603-85c3-654a03590412" alt="Voronoi Texture" width="300" />

</body>
</html>
