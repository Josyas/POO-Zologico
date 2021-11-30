namespace POO_Zologico {
    class AnimalPlus:Animal {

        public string TipoAlimentacao { get; set; }

        public AnimalPlus():base() {
            TipoAlimentacao = "";
        }

        public AnimalPlus(string espeice, double peso, string tipoAlimentacao): base(espeice, peso) {
            TipoAlimentacao = tipoAlimentacao;
        }

        public void ExibirDados() {
            System.Console.WriteLine("Especie: " + Especie);
            System.Console.WriteLine("Peso: " + Peso);
            System.Console.WriteLine("Tipo de alimentação: " + TipoAlimentacao);
        }

    }
}
