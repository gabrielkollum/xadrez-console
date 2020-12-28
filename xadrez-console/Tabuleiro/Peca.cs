namespace tabuleiro {
    class Peca {
       
        public Posicao poiscao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimento { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor) {
            this.poiscao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimento = 0;
        }

    }
}
