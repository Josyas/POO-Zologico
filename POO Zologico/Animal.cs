namespace POO_Zologico {
    class Animal {

       public string Especie { get; set; }
       public double Peso { get; set; } 
        
       public Animal(string especie, double peso) {
            Especie = especie;
            Peso = peso;
        }
        
       public Animal() {
            Especie = "";
            Peso = 0;
       }

    }
}
