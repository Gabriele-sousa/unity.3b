# unity.3b
## Projeto de LP músicas
Esse é projeto solicitado em aula com intuito criarmos um jogo a partir de três musicas sendo elas:
* call the nightngale - Vian Izak
* Tsar - Kamaitachi
* Karma - AJR
O intuito do projeto é familiarizar o uso de oprientação a objeto na engine Unity

## Requisitos
Para acessar a cena é necessario o Unity com a versão `2022.2.15f1`

## Instalação
1. Clonar o projeto 'https://github.com/Gabriele-sousa/unity.3b.git'.
2. Abrir o projeto no Unity.

## Desenvolvimento
Para Criar esse projeto foram utilizados os seguintes passos
1. Baixar assets na asset store.
* Esses foram os assets baixados para o projeto

  (imagem1)

2. Colocar os game objects na cena.

   (imagem2)

3. Criar os script e os programar

   (imagem3)

## Programando o Camera Manager Script
# Camera Manager Script

* Variáveis Públicas
  * `followSpeed`: A velocidade com que a câmera segue o alvo.
  * `mouseSpeed`: A sensibilidade do movimento do mouse para girar a câmera.
  * `cameraDist`: A distância inicial da câmera ao alvo.
  * `target`: O objeto que a câmera deve seguir.

<br>

* Variáveis Privadas
  * `pivot`: O ponto de rotação da câmera.
  * `camTrans`: A transformação da câmera.
  * `turnSmoothing`: O valor de suavização para as rotações.
  * `minAngle e maxAngle`: Os ângulos mínimo e máximo de inclinação da câmera.
  * `smoothX, smoothY, smoothXvelocity, smoothYvelocity`: Variáveis de controle de suavização de rotação.
  * `lookAngle e tiltAngle`: Os ângulos de olhar e inclinação da câmera.

<br>

* Métodos
  * `Init()`: Inicializa as variáveis camTrans e pivot com a câmera principal e seu pai.
  * `FollowTarget(float d)`: Move a câmera em direção ao alvo com uma velocidade suavizada.
  * `HandleRotations(float d, float v, float h, float targetSpeed)`: Controla as rotações da câmera com base nos movimentos do mouse.
  * `FixedUpdate()`: Chamado em intervalos fixos, lê a entrada do mouse e atualiza o comportamento da câmera.
  * `LateUpdate()`: Chamado após o Update(), ajusta a posição da câmera para evitar colisões com objetos.

<br>

* Comportamento da Câmera
  * A câmera segue o alvo com uma velocidade configurável.
  * O movimento do mouse controla a rotação horizontal e vertical da câmera.
  * A suavização é aplicada às rotações para evitar movimentos bruscos.
  * A câmera pode ser inclinada dentro de ângulos mínimos e máximos definidos.

## Programando o Character Control
# Character Control Script

* Variáveis Públicas
  * `speed`: A velocidade de movimento do personagem no chão.
  * `airVelocity`: A velocidade de movimento do personagem no ar.
  * `gravity`: A força da gravidade que afeta o personagem.
  * `maxVelocityChange`: A mudança máxima de velocidade permitida por quadro.
  * `jumpHeight`: A altura do salto do personagem.
  * `maxFallSpeed`: A velocidade máxima de queda permitida.
  * `rotateSpeed`: A velocidade de rotação do personagem.
  * `cam`: A câmera usada para determinar a direção de movimento com base na visão.

<br>

* Variáveis Privadas
  * `moveDir`: A direção de movimento do personagem.
  * `rb`: O componente Rigidbody do personagem para simulação de física.
  * `distToGround`: A distância do centro do personagem ao chão.
  * `canMove`: Um indicador de se o personagem pode se mover.
  * `isStunned`: Um indicador de se o personagem está atordoado.
  * `wasStunned`: Um indicador de se o personagem estava atordoado antes de ficar atordoado novamente.
  * `pushForce`: A força com que o personagem é empurrado quando atingido.
  * `pushDir`: A direção do empurrão.
  * `checkPoint`: A posição do último ponto de verificação do personagem.
  * `slide`: Um indicador de se o personagem está deslizando.

<br>

* Métodos
  * `IsGrounded()`: Verifica se o personagem está no chão usando um raio.
  * `Awake()`: Inicializa o componente Rigidbody e outros valores no início.
  * `FixedUpdate()`: Lida com a física e o movimento do personagem.
  * `Update()`: Lê a entrada do jogador e determina a direção do movimento com base na visão da câmera.
  * `CalculateJumpVerticalSpeed()`: Calcula a velocidade vertical necessária para alcançar a altura de salto desejada.
  * `HitPlayer(Vector3 velocityF, float time)`: Empurra o personagem com uma força especificada e controla o atordoamento.
  * `LoadCheckPoint()`: Move o personagem de volta ao último ponto de verificação.
  * `Decrease(float value, float duration)`: Diminui gradualmente a força de empurrão ou atordoamento.

<br>

* Comportamento do Personagem
  * O personagem pode se mover no chão com uma velocidade controlável e pular.
  * O movimento é direcionado com base na visão da câmera.
  * A física do Rigidbody é usada para simular movimento realista.
  * O personagem pode ser empurrado e atordoado por forças externas.
  * O script suporta pontos de verificação para recarregar a posição do personagem.

### script feito por AisuKase Studio reescrito e estudado
