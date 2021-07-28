# Xadrez
Um jogo de xadrez desenvolvido com C# .Net para simular um jogo de xadrez, nesse projeto foi usado as tecnicas de desenvolvimento como, herança, polimorfismo, enums e composição de objetos. Nele foi implantado um tabuleiro de xadrez usando matrizes e o conceito de herança para a criação das peças e a implantação de suas regras no jogo. Além disso foi implementada algumas jogadas especiais do xadrez como a jogada especial Promoção, En passant, roque pequeno e roque grande.

## Arquitetura do sistema de xadrez
Nesse projeto estamos usando um principio de projeto chamado padrão de camadas, onde foi divido o projeto em 3 camadas basicas: 
### Camada Tabuleiro
- Onde fica as caracteristica do tabuleiro, a cor das peça, basicamente é a representação basica de um tabuleiro.

### Camada Jogo de xadrez
- Aqui é onde fica as regras do jogo de xadrez.

### Camada de aplicação
- É o aplicativo em si, está camada vai consumir as outras duas camadas e formar a aplicação.

![](https://github.com/DiegoLins10/Xadrez/blob/master/Arqitetra%20do%20sistema%20de%20xadrez.png)
