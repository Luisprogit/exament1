# -*- coding: cp1252 -*-
def ejer1():


    precio = float(input("Ingrese el precio del producto: "))
    codigo = int(input("Ingrese el código de descuento (1=Estudiante, 2=Empleado, 3=Cliente frecuente): "))


    descuento = 0

    if codigo == 1:  
      descuento = 0.10  
    elif codigo ==2:  
      descuento = 0.15  
    elif codigo == 3:
    
        descuento = 0.20     
    else:
    
        print("respuesta invalida ")      
    precio_final = precio - (precio * descuento)


   
    if precio > 500:
    
        precio_final = precio_final - (precio_final * 0.05)

    print(f"El precio final a pagar es: {precio_final:.2f}")
ejer1()

def ejer2():
    import math

nota = int(input("Ingrese una nota (0-20): "))


if nota < 0 or nota > 20:
    print("respuesta invalida la nota debe estar entre 0 y 20.")
    exit()


if 0 <= nota <= 10:
    clasificacion = "Desaprobado"
elif 11 <= nota <= 13:
    clasificacion = "Regular"
elif 14 <= nota <= 17:
    clasificacion = "Bueno"
elif 18 <= nota <= 20:
    clasificacion = "Excelente"

print(f"Clasificación: {clasificacion}")


if nota >= 14 and nota % 2 == 0:
    print("Buen desempeño con nota par.")
elif nota % 2 != 0 or nota <= 11:
    print("Necesita reforzar.")


raiz = math.sqrt(nota)
cubo = nota ** 3

print(f"Raíz cuadrada de la nota: {raiz:.1f}")
print(f"La nota al cubo es: {cubo}")
ejer2()