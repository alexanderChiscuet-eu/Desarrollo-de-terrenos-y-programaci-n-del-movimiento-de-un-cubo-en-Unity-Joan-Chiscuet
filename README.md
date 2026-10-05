# Mini ciudad sencilla en Unity

Escena academica con un terreno verde, pequeñas colinas y una mini ciudad. Los diez edificios principales son cubos de distintos colores y alturas. Las calles son negras, con aceras y marcas viales. Incluye arboles y dos coches decorativos.

## Como ejecutar
Descarga el repositorio con Code > Download ZIP y extrae su contenido.

1. Abre la carpeta del proyecto en Unity Hub con Add > Add project from disk.
2. Usa Unity 6000.6.4f1, con Universal Render Pipeline (URP).
3. Abre Assets/EscenaSimple/EscenaSimple.unity.
4. En la pestaña Game, pulsa Play y haz clic dentro de la escena.
5. Mueve el cubo blanco con WASD o las flechas. Pulsa R para volver al inicio.
6. Pulsa Play otra vez para detener la ejecucion.

## Elementos de la escena
- Terrain de 60 x 60 metros, con centro plano y colinas exteriores.
- Diez edificios hechos con cubos, de colores y alturas diferentes.
- Calles negras, aceras, paso peatonal y lineas de carril.
- Seis arboles y dos coches decorativos.
- Luz direccional con sombras y camara que sigue al cubo jugador.
- MovimientoCubo.cs controla el movimiento con CharacterController y el seguimiento de la camara.

La escena es sencilla a proposito: permite practicar terrenos, cubos, materiales, iluminacion y movimiento sin assets externos.

## Entrega
El proyecto incluye Assets (con archivos .meta), Packages, ProjectSettings, Documentacion, README.md y .gitignore. Unity regenera Library y otras carpetas temporales al abrirlo.

Para completar la entrega, graba un video de 3 a 5 minutos siguiendo Documentacion/GuionVideo.md y publica su enlace junto con el de este repositorio.
