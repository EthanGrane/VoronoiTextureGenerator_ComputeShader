# Voronoi Texture Generator using Compute Shader

Este proyecto implementa un generador de texturas Voronoi utilizando Compute Shaders en Unity. La función principal de este generador es crear texturas de ruido que pueden ser utilizadas en shaders para mejorar visualmente los gráficos de los juegos y aplicaciones.

<img src="https://github.com/user-attachments/assets/29a83d1c-d81e-4603-85c3-654a03590412" alt="Voronoi Texture" width="300" />

## Características

- **Tres modos de Voronoi**: 
  - **Greyscale**: Genera texturas en escala de grises.
<img src="https://github.com/user-attachments/assets/46a84c5c-a61e-4f81-be2a-c4730db9eaf5" alt="Greyscale" width="300" />
- **Floor**: Crea patrones que simulan superficies de piso con opciones para intersecciones.
<img src="https://github.com/user-attachments/assets/1959d206-e534-4aa1-8b9c-5f204f2ee7fc" alt="Floor" width="300" />
- **Crystal**: Produce texturas con un efecto de cristal.
<img src="https://github.com/user-attachments/assets/16572c62-9d7d-4087-ae5f-0f4bc1637c48" alt="Diamond" width="300" />
  
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

## Capturas de pantalla

