# cifrado_extremo_a_extremo
Prueba de concepto de cifrado de extremo a extremo (E2EE) usando C#

# Objetivos
Demostrar de manera práctica cómo funciona el cifrado de extremo a extremo, este trabajo se realiza originalmente para actividades educativas de la fundación universitaria católica del norte.

# Cómo funciona
1. Se debe ejecutar dos instancias de la aplicación. Cada instancia se supone que será un extremo entre la comunicación de por ejemplo un chat.
Cada uno de ellos tiene una propia clave publica representada en una cadena de bytes (enteros) separados por coma.
2. Se debe copiar la clave publica de un extremo en el espacio del otro.
3. Escribir el mensaje a cifrar en el extremo 1 y hacer clic en Cifrar, el sistema presentará el valor cifrado en la misma representación de números enteros.
4. Copie el mensaje cifrado y peguelo en el campo derecho del otro extremo.
5. Haga clic en Descifrar
6. El mensaje descifrado se mostrará en el cajón de texto.
