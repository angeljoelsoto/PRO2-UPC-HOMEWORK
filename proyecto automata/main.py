from automata import Automata


cadena = input("Ingrese una cadena de texto para validar: ")
automata = Automata()

if automata.es_cadena_valida(cadena):
    print("Cadena válida")
else:
    print("Cadena inválida")
    