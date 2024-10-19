# Voronoi Texture Generator using Compute Shader

Este proyecto implementa un generador de texturas Voronoi utilizando Compute Shaders en Unity. La función principal de este generador es crear texturas de ruido que pueden ser utilizadas en shaders para mejorar visualmente los gráficos de los juegos y aplicaciones.

![image](https://github.com/user-attachments/assets/4e1dc1c8-8ff0-4155-8bd6-9f714bbdc7ec)

## Características

- **Tres modos de Voronoi**: 
  - **Greyscale**: Genera texturas en escala de grises.
    ![greyscale](https://github.com/user-attachments/assets/6a68cc20-c160-45a7-9ca8-898e786c0040)
  - **Floor**: Crea patrones que simulan superficies de piso con opciones para intersecciones.  
    ![floor](https://github.com/user-attachments/assets/95d75369-7f26-408c-849d-4ddfcc30220e)
  - **Crystal**: Produce texturas con un efecto de cristal.  
    ![Crystal](https://github.com/user-attachments/assets/0caa9b64-1e32-48b0-aee2-268f513af0a1)

- **Configuración de parámetros**:
  - **Tamaño de textura**: Configura el tamaño de la textura generada.
  - **Número de puntos**: Establece la cantidad de puntos utilizados en el cálculo de la textura.
  - **Saturación**: Controla la saturación del color de la textura generada.
  - **Tiled**: Opción para repetir el patrón de textura en un modo de teselado.
  - **Colores invertidos**: Permite invertir los colores de la textura.
  
- **Exportación de texturas**: Posibilidad de exportar la textura generada a un archivo PNG.

## Cómo usar

1. **Agregar el script**: Adjunta el script `VoronoiGenerator` a un GameObject en tu escena de Unity.
2. **Configurar parámetros**: Ajusta los parámetros en el inspector de Unity según tus necesidades.
3. **Generar la textura**: Haz clic en el botón "Generate" para crear la textura Voronoi.
4. **Previsualizar la textura**: La textura generada se mostrará en una vista previa en el inspector.
5. **Exportar la textura**: Utiliza el botón "Export Texture" para guardar la textura en tu sistema.

## Dependencias

- **Unity**: Este proyecto requiere Unity para su ejecución.
- **Compute Shaders**: Asegúrate de que tu proyecto de Unity esté configurado para utilizar Compute Shaders.

## Contribuciones

Si deseas contribuir a este proyecto, siéntete libre de hacer un fork y enviar tus mejoras o sugerencias.

## Licencia

Este proyecto está bajo la Licencia MIT. Consulta el archivo `LICENSE` para obtener más detalles.
