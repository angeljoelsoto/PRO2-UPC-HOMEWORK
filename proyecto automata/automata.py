class Automata:
    def _init_(self):
        pass
    
    def es_cadena_valida(self, cadena):
        # Resetear al estado inicial para cada nueva validación
        estado = 0
        tiene_vocal = False
        
        for caracter in cadena:
            if estado == 0:
                if caracter.isupper():
                    estado = 1
                else:
                    return False    

            elif estado == 1:
                if caracter in "aeiouAEIOU":
                    tiene_vocal = True 

                if not(caracter == "-" or caracter == " " or caracter.isalpha()):
                    return False
                
        return tiene_vocal

               